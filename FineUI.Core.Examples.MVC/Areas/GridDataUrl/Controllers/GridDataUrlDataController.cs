using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Newtonsoft.Json.Linq;


namespace FineUI.Core.Examples.MVC.Areas.GridDataUrl.Controllers
{
    [Area("GridDataUrl")]
    public class GridDataUrlDataController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridDataUrl/GridDataUrlData
        public IActionResult Index(bool? data2)
        {
            JArray ja = new JArray();

            DataTable source = null;
            if (data2.HasValue && data2.Value)
            {
                source = DataSourceUtil.GetDataTable2();
            }
            else
            {
                source = DataSourceUtil.GetDataTable();
            }

            foreach (DataRow row in source.Rows)
            {
                JObject jo = new JObject();
                jo.Add("Id", (int)row["Id"]);
                jo.Add("Name", row["Name"].ToString());
                jo.Add("Gender", (int)row["Gender"]);
                jo.Add("EntranceYear", (int)row["EntranceYear"]);
                jo.Add("AtSchool", (bool)row["AtSchool"]);
                jo.Add("Major", row["Major"].ToString());
                jo.Add("Group", (int)row["Group"]);

                ja.Add(jo);
            }

            return Content(ja.ToString(Newtonsoft.Json.Formatting.None));
        }


    }
}