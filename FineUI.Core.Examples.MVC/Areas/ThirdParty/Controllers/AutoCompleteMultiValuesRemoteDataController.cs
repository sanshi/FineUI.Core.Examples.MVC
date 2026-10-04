using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;

namespace FineUI.Core.Examples.MVC.Areas.ThirdParty.Controllers
{
    // 独立 HTTP 响应入口：不渲染 FineUI 页面，也不初始化页面主题等配置。
    [Area("ThirdParty")]
    [Route("/ThirdParty/AutoCompleteMultiValuesRemote/SearchResult")]
    public class AutoCompleteMultiValuesRemoteDataController : Controller
    {
        private static readonly string[] LANGUAGES = new string[]
        {
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
