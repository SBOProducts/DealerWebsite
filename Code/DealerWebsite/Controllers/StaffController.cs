using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DealerWebsite.Controllers
{
    public class StaffController : Controller
    {

        public ActionResult List()
        {
            return PartialView();
        }

        public ActionResult Member()
        {
            return View();
        }

    }
}
