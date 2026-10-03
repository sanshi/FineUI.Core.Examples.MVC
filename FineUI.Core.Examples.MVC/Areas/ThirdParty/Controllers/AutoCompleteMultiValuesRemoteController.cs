using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.ThirdParty.Controllers
{
    [Area("ThirdParty")]
    public class AutoCompleteMultiValuesRemoteController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        protected override bool ShouldInitializePageManager(ActionExecutingContext context)
        {
            // 数据和下载请求不需要页面主题、语言等配置。
            return ControllerContext.ActionDescriptor.ActionName != nameof(SearchResult);
        }

        // GET: ThirdParty/AutoCompleteMultiValuesRemote
        public IActionResult Index()
        {
            return View();
        }

        private static readonly string[] LANGUAGES = new string[]{
                "ActionScript",
                "AppleScript",
                "Asp",
                "BASIC",
                "C",
                "C++",
                "Clojure",
                "COBOL",
                "ColdFusion",
                "Erlang",
                "Fortran",
                "Groovy",
                "Haskell",
                "Java",
                "JavaScript",
                "Lisp",
                "Perl",
                "PHP",
                "Python",
                "Ruby",
                "Scala",
                "Scheme"
        };


        [HttpGet]
        public IActionResult SearchResult(string term)
        {
            string result = String.Empty;

            if (!String.IsNullOrEmpty(term))
            {
                term = term.ToLower();

                JArray ja = new JArray();
                foreach (string lang in LANGUAGES)
                {
                    if (lang.ToLower().Contains(term))
                    {
                        ja.Add(lang);
                    }
                }

                result = ja.ToString();
            }

            return Content(result);
        }

    }
}