using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System.Xml;

namespace FineUI.Core.Examples.MVC.Areas.Toolbar.Controllers
{
    [Area("Toolbar")]
    public class MenuDynamicController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Toolbar/MenuDynamic
        public IActionResult Index()
        {
            LoadData();

            return View();
        }


        private void LoadData()
        {
            List<ControlBase> items = new List<ControlBase>();

            XmlDocument doc = DataSourceUtil.LoadXml("~/Areas/Toolbar/Content/menu.xml");

            // 根节点的子节点们
            XmlNodeList nodes = doc.DocumentElement.ChildNodes;
            foreach (XmlNode node in nodes)
            {
                FineUI.Core.Button btn = new FineUI.Core.Button();
                btn.Text = node.Attributes["text"].Value;
                items.Add(btn);

                ResolveMenu(btn, node.ChildNodes);
            }

            ViewBag.ToolbarItems = items.ToArray();
        }

        private void ResolveMenu(ControlBase btn, XmlNodeList nodes)
        {
            PropertyInfo menuInfo = btn.GetType().GetProperty("Menu");
            Menu menu = menuInfo.GetValue(btn, null) as Menu;

            foreach (XmlNode node in nodes)
            {
                XmlAttribute attrURL = node.Attributes["navigateurl"];
                if (attrURL != null)
                {
                    FineUI.Core.MenuHyperLink lnk = new FineUI.Core.MenuHyperLink();
                    lnk.Text = node.Attributes["text"].Value;
                    lnk.NavigateUrl = attrURL.Value;
                    lnk.Target = "_blank";

                    menu.Items.Add(lnk);

                    if (node.ChildNodes.Count > 0)
                    {
                        ResolveMenu(lnk, node.ChildNodes);
                    }
                }
            }
        }

        

        //private XmlDocument DataSourceUtil.LoadXml()
        //{
        //    // 加载XML配置文件
        //    string xmlPath = PageContext.MapPath("~/Areas/Toolbar/Content/menu.xml");
        //    string xmlContent = String.Empty;
        //    using (StreamReader sr = new StreamReader(xmlPath))
        //    {
        //        xmlContent = sr.ReadToEnd();
        //    }
        //    XmlDocument doc = new XmlDocument();
        //    doc.LoadXml(xmlContent);

        //    return doc;
        //}


    }
}