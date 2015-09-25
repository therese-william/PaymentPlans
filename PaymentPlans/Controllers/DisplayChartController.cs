using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaymentPlans.Controllers
{
    public class DisplayChartController : Controller
    {
        // GET: DisplayChart
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult PieChart()
        {
            using (PaymentPlansEntities db = new PaymentPlansEntities())
            {
                var reportdata = db.PaymentPlansReport().ToList();
                return Json(reportdata, JsonRequestBehavior.AllowGet);
            }
        }
    }
}