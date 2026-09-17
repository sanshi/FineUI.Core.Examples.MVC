using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace FineUI.Core.Examples.MVC.Areas.Form.Controllers
{
	[Area("Form")]
    public class RadioButtonListDisabledController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Form/RadioButtonListDisabled
        public IActionResult Index()
        {
            LoadData();

            return View();
        }

        private void LoadData()
        {
            List<TestClass> myList = new List<TestClass>();
            myList.Add(new TestClass("item1", "数据绑定值 1", false));
            myList.Add(new TestClass("item2", "数据绑定值 2", false));
            myList.Add(new TestClass("item3", "数据绑定值 3", true));
            myList.Add(new TestClass("item4", "数据绑定值 4", true));

            ViewBag.RadioButtonList2DataSource = myList;
            ViewBag.RadioButtonList2SelectedValue = "item3";
        }

        #region TestClass

        public class TestClass
        {
            private string _id;

            public string Id
            {
                get { return _id; }
                set { _id = value; }
            }
            private string _name;

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            private bool _enabled;
            public bool Enabled
            {
                get { return _enabled; }
                set { _enabled = value; }
            }

            public TestClass(string id, string name, bool enabled)
            {
                _id = id;
                _name = name;
                _enabled = enabled;
            }
        }

        #endregion


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSubmit_Click(IFormCollection values)
        {
            ShowNotify(values);

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnServerGetSelectedValue_Click(JObject selected)
        {
            if (selected.Count > 0)
            {
                ShowNotify(String.Format("列表一的选中项：{0}（{1}）", selected["label"], selected["value"]));
            }
            else
            {
                ShowNotify("列表一没有选中项！");
            }

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnServerSetSelectedValue_Click()
        {
            UIHelper.RadioButtonList("RadioButtonList1").SelectedValue("value1");

            return UIHelper.Result();
        }

        
        
    }
}