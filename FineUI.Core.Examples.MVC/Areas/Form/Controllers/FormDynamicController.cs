using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc;


namespace FineUI.Core.Examples.MVC.Areas.Form.Controllers
{
    [Area("Form")]
    public class FormDynamicController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Form/FormDynamic
        public IActionResult Index()
        {
            InitFormRows();

            return View();
        }

        private void InitFormRows()
        {
            List<Field> fields = new List<Field>();

            TextBox tbxUser = new TextBox();
            tbxUser.ID = "tbxUserName";
            tbxUser.Text = "";
            tbxUser.Label = "用户名";
            tbxUser.ShowLabel = true;
            tbxUser.ShowRedStar = true;
            tbxUser.Required = true;
            tbxUser.EmptyText = "请输入用户名";
            fields.Add(tbxUser);

            FineUI.Core.DropDownList ddlGender = new FineUI.Core.DropDownList();
            ddlGender.ID = "ddlGender";
            ddlGender.Label = "性别（回发事件）";
            ddlGender.Items.Add("男", "0");
            ddlGender.Items.Add("女", "1");
            ddlGender.AutoSelectFirstItem = false;
            // 添加后台事件处理函数
            ddlGender.Events.Add(new Event("change", Url.Action("ddlGender_SelectedIndexChanged"), "ddlGender"));
            fields.Add(ddlGender);

            ViewBag.DynamicItems = fields.ToArray();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ddlGender_SelectedIndexChanged(string ddlGender_text)
        {
            ShowNotify("选择的性别：" + ddlGender_text);

            return UIHelper.Result();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button1_Click(string tbxUserName, string ddlGender_text)
        {
            ShowNotify("用户名：" + tbxUserName + "  性别：" + ddlGender_text);

            return UIHelper.Result();
        }


    }
}