using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Controllers
{
    /// <summary>
    /// 多语言示例控制器基类：在 <see cref="BaseController"/> 之上提供「按控制器取多语言资源」的便捷方法。
    /// 只有多语言示例需要，所以放在这一层而不是通用控制器基类里。
    /// </summary>
    public class BaseMultilangController : BaseController
    {
        private IHtmlLocalizer _localizer;

        /// <summary>
        /// 控制器的多语言资源
        /// </summary>
        public IHtmlLocalizer Localizer
        {
            get
            {
                if (_localizer == null)
                {
                    _localizer = FineUI.Core.PageContext.GetLocalizer(this.GetType());
                }
                return _localizer;
            }
        }

        /// <summary>
        /// 获取控制器的多语言资源
        /// </summary>
        [NonAction]
        public string GetResource(string name, params object[] arguments)
        {
            if (arguments.Length == 0)
            {
                return Localizer.GetString(name);
            }
            else
            {
                return Localizer.GetString(name, arguments);
            }
        }

        /// <summary>
        /// GetResource 的简写形式，控制器与视图里大量使用。
        /// </summary>
        [NonAction]
        public string _R(string name, params object[] arguments)
        {
            return GetResource(name, arguments);
        }
    }
}
