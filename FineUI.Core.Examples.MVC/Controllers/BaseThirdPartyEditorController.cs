using Microsoft.AspNetCore.Mvc.Filters;

namespace FineUI.Core.Examples.MVC.Controllers
{
    /// <summary>
    /// 实际加载第三方编辑器的页面使用兼容策略；普通外层窗口仍保持严格 CSP。
    /// 首屏与 POST 都应用同一策略，不能只在返回视图的 Action 中设置。
    /// </summary>
    public abstract class BaseThirdPartyEditorController : BaseController
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            PageManager.Instance.CspScripts = false;
        }
    }

    /// <summary>
    /// 一个控制器同时处理普通外层页面与编辑器子页时，仅标记实际编辑器的 GET 和 POST。
    /// 例如 IFrameWindow 与其保存按钮允许第三方脚本，Index 和外层窗口关闭事件仍严格检查。
    /// </summary>
    public sealed class ThirdPartyEditorAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            PageManager.Instance.CspScripts = false;
        }
    }
}
