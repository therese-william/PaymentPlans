using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaymentPlans.Controllers
{
    public class PaymentController : Controller
    {
        // GET: Payment Plan
        public ActionResult Plan()
        {
            using (PaymentPlansEntities db = new PaymentPlansEntities())
            {
                var plans = db.PaymentDetails_SelectAll().ToList();
                return View(plans);
            }
        }
        // GET: Payment Master
        public ActionResult Master()
        {
            using (PaymentPlansEntities db = new PaymentPlansEntities())
            {
                var plans = db.PlanMasters.ToList();
                return View(plans);
            }
        }
    }
}