using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.DataList.Controllers
{
    [Area("DataList")]
    public class DataListSelectionController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnRead_Click(string[] single, string[] multi, string[] keep)
        {
            UIHelper.Label("labResult").Text(
                "单选：" + string.Join(", ", single ?? System.Array.Empty<string>())
                + "；多选：" + string.Join(", ", multi ?? System.Array.Empty<string>())
                + "；保持选择：" + string.Join(", ", keep ?? System.Array.Empty<string>()));
            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnAssign_Click()
        {
            UIHelper.DataList("DataListSingle").SelectedValueArray("guangzhou");
            UIHelper.DataList("DataListMulti").SelectedValueArray("shanghai", "guangzhou");
            UIHelper.DataList("DataListKeep").SelectedValueArray("shanghai", "guangzhou");
            UIHelper.Label("labResult").Text("已设置选择，请点击“读取选择”查看后台收到的值。");
            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnClear_Click()
        {
            UIHelper.DataList("DataListSingle").ClearSelection();
            UIHelper.DataList("DataListMulti").ClearSelection();
            UIHelper.DataList("DataListKeep").ClearSelection();
            UIHelper.Label("labResult").Text("已清空选择，请点击“读取选择”查看后台收到的值。");
            return UIHelper.Result();
        }
    }
}
