using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace FineUI.Core.Examples.MVC.Areas.Form.Controllers
{
    [Area("Form")]
    public class ChangeConfirmFormController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Form/ChangeConfirmForm
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnClosePostBack_Click(IFormCollection values)
        {
            ShowNotify(values);

            // 保存数据后，清空面板内表单字段的改变状态
            UIHelper.SimpleForm("SimpleForm1").ClearDirty();

            return UIHelper.Result();
        }

    }
}