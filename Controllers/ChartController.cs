using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABC.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetChartValues()
        {
            var items = new List<VS>();
            var item = new VS();
            item.SType = "Oil";
            item.Value = 1000.00M;
            items.Add(item);
            var item1 = new VS();
            item1.SType = "AC";
            item1.Value = 5000.00M;
            items.Add(item1);

            var item2 = new VS();
            item2.SType = "Electric";
            item2.Value = 2000.00M;
            items.Add(item2);

            var item3 = new VS();
            item3.SType = "Radiator";
            item3.Value = 6000.00M;
            items.Add(item3);

            return Json(new { items = items });
        }

    }

    public class VS
    {
        public VS()
        {

        }
        public string SType { get; set; }
        public decimal Value { get; set; }
    }
}
