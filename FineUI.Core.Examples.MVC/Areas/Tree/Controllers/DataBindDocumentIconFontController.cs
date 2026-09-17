using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System.Xml;

namespace FineUI.Core.Examples.MVC.Areas.Tree.Controllers
{
    [Area("Tree")]
    public class DataBindDocumentIconFontController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Tree/DataBindDocumentIconFont
        public IActionResult Index()
        {
            LoadData();

            return View();
        }

        private void LoadData()
        {
            ViewBag.Tree1DataSource = GetDataSource();

        }

        private XmlDocument GetDataSource()
        {
            string xmlPath = PageContext.MapPath("~/Areas/Tree/Content/website_iconfont.xml");

            string xmlContent = String.Empty;
            using (StreamReader sr = new StreamReader(xmlPath))
            {
                xmlContent = sr.ReadToEnd();
            }

            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(xmlContent);

            return xdoc;
        }


    }
}