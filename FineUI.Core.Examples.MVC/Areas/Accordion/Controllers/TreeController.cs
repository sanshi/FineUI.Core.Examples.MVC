using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System.Xml;

namespace FineUI.Core.Examples.MVC.Areas.Accordion.Controllers
{
    [Area("Accordion")]
    public class TreeController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Accordion/Tree
        public IActionResult Index()
        {
            LoadData();

            return View();
        }

        // GET: Accordion/Tree/DefaultPage
        public IActionResult DefaultPage()
        {
            return View();
        }

        private void LoadData()
        {
            string xmlPath = PageContext.MapWebPath("~/res/menu.xml");

            string xmlContent = String.Empty;
            using (StreamReader sr = new StreamReader(xmlPath))
            {
                xmlContent = sr.ReadToEnd();
            }

            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(xmlContent);

            ViewBag.Tree1DataSource = xdoc;
        }


    }
}