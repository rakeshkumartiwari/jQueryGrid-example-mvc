using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JqGridExampleMVC.Controllers
{
    public class HolidayController : Controller
    {
        // GET: Holiday
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetHolidays()
        {
            using (var dc = new HolidayDbEntities())
            {
                var holidays = dc.Holidays.ToList();
                return Json(holidays, JsonRequestBehavior.AllowGet );
            }

        }
    }
   
}