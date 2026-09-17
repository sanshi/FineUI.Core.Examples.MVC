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
    public class DataBindDocumentController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Tree/DataBindDocument
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
            string xmlPath = PageContext.MapPath("~/Areas/Tree/Content/website.xml");

            string xmlContent = String.Empty;
            using (StreamReader sr = new StreamReader(xmlPath))
            {
                xmlContent = sr.ReadToEnd();
            }

            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(xmlContent);

            return xdoc;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnClear_Click()
        {
            UIHelper.Tree("Tree1").DataSource(null);
            
            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnReBind_Click()
        {
            UIHelper.Tree("Tree1").DataSource(GetDataSource());

            return UIHelper.Result();
        }

        

    }
}