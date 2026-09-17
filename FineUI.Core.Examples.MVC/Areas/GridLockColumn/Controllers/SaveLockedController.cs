using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.GridLockColumn.Controllers
{
    [Area("GridLockColumn")]
    public class SaveLockedController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridLockColumn/SaveLocked
        public IActionResult Index()
        {
            LoadData();

            return View();
        }

        private void LoadData()
        {
            ViewBag.LockedColumns = GetLockedColumns();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Grid1_ColumnLockUnlock(string type, string columnId)
        {
            // 模拟操作数据库中的数据
            List<string> lockedColumns = GetLockedColumns();
            if (type == "lock")
            {
                if (!lockedColumns.Contains(columnId))
                {
                    lockedColumns.Add(columnId);
                }
            }
            else if (type == "unlock")
            {
                if (lockedColumns.Contains(columnId))
                {
                    lockedColumns.Remove(columnId);
                }
            }

            HttpContext.Session.SetObject(KEY_FOR_DATASOURCE_SESSION, lockedColumns);

            return UIHelper.Result();
        }

        #region Data

        private static readonly string KEY_FOR_DATASOURCE_SESSION = "GridLockColumn.SaveLocked";

        // 模拟在服务器端保存数据
        // 特别注意：在真实的开发环境中，不要在Session放置大量数据，否则会严重影响服务器性能
        private List<string> GetLockedColumns()
        {
            if (HttpContext.Session.GetObject<List<string>>(KEY_FOR_DATASOURCE_SESSION) == null)
            {
                HttpContext.Session.SetObject(KEY_FOR_DATASOURCE_SESSION, new List<string>() { });
            }
            return HttpContext.Session.GetObject<List<string>>(KEY_FOR_DATASOURCE_SESSION);
        }


        #endregion

    }
}