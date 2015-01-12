using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DealerWebsite.Controllers
{
    public class ImageController : Controller
    {

        public ActionResult ImageGrid()
        {
            return PartialView();
        }

        public ActionResult ImageList()
        {
            
            return PartialView();
        }

    }
}
