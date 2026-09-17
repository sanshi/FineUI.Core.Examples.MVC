using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Text;
using System.Xml;

namespace FineUI.Core.Examples.MVC.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        public IActionResult Index()
        {
            LoadData();

            return View("Index");
        }


        #region Views

        // GET: Themes
        public IActionResult Themes()
        {
            return View();
        }

        // GET: LoadingCSS
        public ActionResult LoadingCSS()
        {
            return View();
        }

        // GET: Source
        public IActionResult Source()
        {
            return View();
        }

        // GET: SourceFile
        public IActionResult SourceFile()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Error()
        {
            ViewBag.ErrorMessage = "Error";

            var exception = HttpContext.Features.Get<Microsoft.AspNetCore.Diagnostics.IExceptionHandlerFeature>();
            if (exception != null)
            {
                ViewBag.ErrorMessage = exception.Error.Message;
            }

            ViewBag.RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier;

            return View();
        }

        #endregion

        #region LoadData

        // 框架页风格
        private string _framePageStyle = "f-dark-left";
        // 是否仅显示社区版示例
        private bool _showOnlyCommunity = false;
        // 显示模式
        private string _displayMode = "normal";
        // 主选项卡标签
        private string _mainTabs = "multi";
        // 语言
        private string _lang = "zh_CN";
        // 搜索文本
        private string _searchText = "";
        // 示例数
        private int _examplesCount = 0;

        private void LoadData()
        {
            string cookie = String.Empty;

            // 从Cookie中读取 - 框架页风格
            cookie = Request.Cookies["FramePageStyle"];
            if (cookie != null)
            {
                _framePageStyle = cookie;
            }

            // 从Cookie中读取 - 是否仅显示社区版示例
            cookie = Request.Cookies["ShowOnlyCommunity"];
            if (cookie != null)
            {
                _showOnlyCommunity = Convert.ToBoolean(cookie);
            }


            // 从Cookie中读取 - 显示模式
            cookie = Request.Cookies["DisplayMode"];
            if (!String.IsNullOrEmpty(cookie))
            {
                _displayMode = cookie;
            }

            // 从Cookie中读取 - 语言
            cookie = Request.Cookies["Language"];
            if (!String.IsNullOrEmpty(cookie))
            {
                _lang = cookie;
            }


            // 从Cookie中读取 - 搜索文本
            cookie = Request.Cookies["SearchText"];
            if (!String.IsNullOrEmpty(cookie))
            {
                _searchText = HttpUtility.UrlDecode(cookie);
            }

            // 从Cookie中读取 - 主选项卡标签
            cookie = Request.Cookies["MainTabs"];
            if (!String.IsNullOrEmpty(cookie))
            {
                _mainTabs = cookie;
            }
			
            LoadTreeMenuData();

			ViewBag.CookieFramePageStyle = _framePageStyle;
            ViewBag.CookieShowOnlyCommunity = _showOnlyCommunity;
            ViewBag.CookieIsCommunity = Constants.IS_COMMUNITY_EDITION;
            ViewBag.CookieDisplayMode = _displayMode;
            ViewBag.CookieMainTabs = _mainTabs;
            ViewBag.CookieLang = _lang;
            ViewBag.CookieSearchText = _searchText;

            ViewBag.ProductVersion = GlobalConfig.ProductVersion;
            ViewBag.ExamplesCount = _examplesCount.ToString();
        }

        private void LoadTreeMenuData()
        {
            string xmlPath = FineUI.Core.PageContext.MapWebPath("~/res/menu.xml");

            string xmlContent = String.Empty;
            using (StreamReader sr = new StreamReader(xmlPath))
            {
                xmlContent = sr.ReadToEnd();
            }

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlContent);

            IList<TreeNode> nodes = new List<TreeNode>();
	
			// 返回全部的叶子节点个数
            _examplesCount = ResolveXmlNodeList(nodes, doc.DocumentElement.ChildNodes);

            // 视图数据
            ViewBag.TreeMenuNodes = nodes.ToArray();
        }


        private int _nodeIndex = 0;

        private int ResolveXmlNodeList(IList<TreeNode> nodes, XmlNodeList xmlNodes)
        {
            // nodes 中渲染到页面上的节点个数
            int nodeVisibleCount = 0;

            foreach (XmlNode xmlNode in xmlNodes)
            {
                if (xmlNode.NodeType != XmlNodeType.Element)
                {
                    continue;
                }

                TreeNode node = new TreeNode();

                // 是否叶子节点
                bool isLeaf = xmlNode.ChildNodes.Count == 0;

                bool currentNodeIsVisible = true;

                string nodeText = "";
                bool nodeIsEnterprise = false;

                XmlAttribute textAttr = xmlNode.Attributes["Text"];
                if (textAttr != null)
                {
                    nodeText = textAttr.Value;
                }

                // 是否企业版
                XmlAttribute isEnterpriseAttr = xmlNode.Attributes["IsEnterprise"];
                if (isEnterpriseAttr != null)
                {
                    nodeIsEnterprise = isEnterpriseAttr.Value.ToLower() == "true";
                }

                string nodeVersion = "";
                // 示例关联的版本号
                XmlAttribute versionAttr = xmlNode.Attributes["Version"];
                if (versionAttr != null)
                {
                    nodeVersion = versionAttr.Value;
                }


                int childVisibleCount = 0;
                if (isLeaf)
                {
                    // 仅显示社区版示例
                    if (_showOnlyCommunity && nodeIsEnterprise)
                    {
                        currentNodeIsVisible = false;
                    }

                    // 存在搜索文本
                    if (!String.IsNullOrEmpty(_searchText))
                    {
                        if (!nodeText.Contains(_searchText))
                        {
                            currentNodeIsVisible = false;
                        }
                    }
                }
                else
                {
                    // 递归
                    childVisibleCount = ResolveXmlNodeList(node.Nodes, xmlNode.ChildNodes);

                    nodeVisibleCount += childVisibleCount;

                    if (childVisibleCount == 0)
                    {
                        currentNodeIsVisible = false;
                    }
                    else
                    {
                        // 存在搜索文本
                        if (!String.IsNullOrEmpty(_searchText))
                        {
                            // 展开节点
                            node.Expanded = true;
                        }
                    }

                    // 目录节点不可选择
                    node.Selectable = false;
                }

                if (currentNodeIsVisible)
                {
                    foreach (XmlAttribute attribute in xmlNode.Attributes)
                    {
                        string name = attribute.Name;
                        string value = attribute.Value;

                        if (name == "Text")
                        {
                            // Text需要特殊处理
                            if (isLeaf)
                            {
                                // 设置节点的提示信息
                                node.ToolTip = nodeText;
                            }

                            // 存在 IsEnterprise=True 属性，则改变 Text 的值
                            if (nodeIsEnterprise)
                            {
                                node.IconFont = IconFont._Enterprise;
                                //nodeText = nodeText + "&nbsp;<span class=\"iscorp\">Corp.</span>";
                            }

                            StringBuilder nodeTextBuilder = new StringBuilder();
                            nodeTextBuilder.AppendFormat("<span class=\"text\">{0}</span>", nodeText);

                            if (childVisibleCount > 0)
                            {
                                nodeTextBuilder.AppendFormat("<span class=\"menu-child-count\">{0}</span>", childVisibleCount);
                            }

                            if(!String.IsNullOrEmpty(nodeVersion))
                            {
                                nodeTextBuilder.AppendFormat("<span class=\"menu-version\">{0}</span>", nodeVersion);
                            }

                            // 节点文本是开发者拼接的可信 HTML，用 TextRawHtml 标记为原样输出（不转义）
                            node.TextRawHtml = new RawHtml(nodeTextBuilder.ToString());
                        }
                        else
                        {
                            node.SetPropertyValue(name, value);
                        }
                    }

                    // 为每个节点分配一个ID
                    node.NodeID = String.Format("tn_{0}", _nodeIndex++);

                    nodes.Add(node);



                    // 示例数只计算叶子节点
                    if (isLeaf)
                    {
                        nodeVisibleCount++;
                    }

                }

            }

            return nodeVisibleCount;
        }

        #endregion


        /// <summary>
        /// 公共下载入口：图片上传示例与 WebUploader 示例共享。
        /// 读取保存在 wwwroot 之外（UploadStorage.UPLOAD_DIR）的上传文件。
        ///
        /// 输出形态由**调用方**声明，而不是由文件扩展名推断：
        /// 不带 inline（GetFileUrl）→ 一律 application/octet-stream + attachment，浏览器只下载不渲染；
        /// 带 inline=1（GetImageUrl）→ 仅当扩展名在图片白名单内才按 image/xxx 内联显示，
        /// 白名单外（.html / .svg 等）降级为附件下载。
        ///
        /// 于是"能被内联渲染的集合"恒为那 5 种位图，与谁来请求、请求方怎么写参数无关。
        /// </summary>
        [HttpGet]
        public IActionResult Download(string file, string inline)
        {
            if (String.IsNullOrEmpty(file))
            {
                return NotFound();
            }

            // 安全①：只取文件名部分，剥离任何目录信息，防止路径穿越（如 ..\..\appsettings.json）
            string safeName = Path.GetFileName(file);
            if (safeName != file)
            {
                return BadRequest();
            }

            string fullPath = UploadStorage.GetUploadFilePath(safeName);
            if (!System.IO.File.Exists(fullPath))
            {
                return NotFound();
            }

            // 禁止浏览器嗅探内容改写 Content-Type
            Response.Headers["X-Content-Type-Options"] = "nosniff";

            // 安全②：只有白名单内的图片、且调用方明确要求内联时，才按 image/xxx 输出。
            string imageContentType = UploadStorage.IsInlineRequested(inline) ? UploadStorage.GetImageContentType(safeName) : null;
            if (imageContentType != null)
            {
                // 不写 Content-Disposition，浏览器默认即内联
                return PhysicalFile(fullPath, imageContentType);
            }

            // 其余一律以附件下载：传上来的 .html / .svg 等不会被渲染，从根上杜绝存储型 XSS。
            // 传了 fileDownloadName，框架会自动写出 Content-Disposition（含支持 UTF-8 文件名的
            // filename*，中文名不乱码）。
            return PhysicalFile(fullPath, "application/octet-stream", safeName);
        }

    }
}
