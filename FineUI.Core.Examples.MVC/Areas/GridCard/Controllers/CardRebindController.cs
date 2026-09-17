using Microsoft.AspNetCore.Mvc;


namespace FineUI.Core.Examples.MVC.Areas.GridCard.Controllers
{
    [Area("GridCard")]
    public class CardRebindController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridCard/CardRebind
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Button1_Click(string[] fields, string source)
        {
            var grid1 = UIHelper.Grid("Grid1");

            if (source == "source1")
            {
                grid1.DataSource(DataSourceUtil.GetDataTable(), fields);
                grid1.Attribute("data-source-key", "source2");
            }
            else
            {
                grid1.DataSource(null);
                grid1.Attribute("data-source-key", "source1");
            }

            return UIHelper.Result();
        }


    }
}
