using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.IFrame.Controllers
{
    [Area("IFrame")]
    public class PassValueController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: IFrame/PassValue
        public IActionResult Index()
        {
            return View();
        }

        // GET: IFrame/PassValue/IFrameWindow
        public IActionResult IFrameWindow()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button1_Click(string province)
        {
            var window1 = UIHelper.Window("Window1");
            string openUrl = String.Format("{0}?selected={1}", Url.Content("~/IFrame/PassValue/IFrameWindow"), HttpUtility.UrlEncode(province));

            PageContext.RegisterStartupScript(window1.GetSaveStateReference("tbxProvince") + window1.GetShowReference(openUrl));

            return UIHelper.Result();
        }


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Window1_Close()
        //{
        //    ShowNotify("触发了 Window1 的关闭事件！");

        //    return UIHelper.Result();
        //}


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ddlSheng_SelectedIndexChanged(string province)
        {
            PageContext.RegisterStartupScript(ActiveWindow.GetWriteBackValueReference(province) + ActiveWindow.GetHideReference());
            
            return UIHelper.Result();
        }

    }
}