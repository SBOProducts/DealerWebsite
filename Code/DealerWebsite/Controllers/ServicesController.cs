using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DealerWebsite.Controllers
{
    public class ServicesController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Service(int Id)
        {
            return View();
        }

    }
}
