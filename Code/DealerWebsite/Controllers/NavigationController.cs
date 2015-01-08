using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DealerWebsite.Controllers
{
    public class NavigationController : Controller
    {

        public ActionResult MainNav()
        {
            return PartialView();
        }

    }
}
