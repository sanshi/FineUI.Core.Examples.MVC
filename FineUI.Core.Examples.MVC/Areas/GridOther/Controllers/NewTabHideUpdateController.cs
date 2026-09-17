using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Newtonsoft.Json.Linq;


namespace FineUI.Core.Examples.MVC.Areas.GridOther.Controllers
{
    [Area("GridOther")]
    public class NewTabHideUpdateController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridOther/NewTabHideUpdate
        public IActionResult Index()
        {
            return View();
        }

        // GET: GridOther/NewTabHideUpdate/Window
        public IActionResult Window()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CustomEvent(string param)
        {
            Alert.Show(String.Format("来自子页面的参数：{0}", param));

            return UIHelper.Result();
        }

    }
}