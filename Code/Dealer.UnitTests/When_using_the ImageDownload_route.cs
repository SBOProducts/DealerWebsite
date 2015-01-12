using System.Web.Routing;
using DealerWebsite;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcRouteTester;
using DealerWebsite.Controllers;

namespace Dealer.UnitTests
{
    [TestFixture]
    public class When_using_the_ImageDownload_route
    {
        private RouteCollection routes;

        [SetUp]
        public void Setup()
        {
            routes = new RouteCollection();
            RouteConfig.RegisterRoutes(routes);
            RouteAssert.UseAssertEngine(new NunitAssertEngine());
        }

        [Test]
        public void I_can_download_a_thumbnail()
        {
            var expectedRoute = new { controller = "Image", action = "Download", size = "thumbnail", name = "Load-Trail-10-23-hydraulic-lift-dump.jpg", id = 387 };
            RouteAssert.HasRoute(routes, "/Image/thumbnail/387/Load-Trail-10-23-hydraulic-lift-dump.jpg", expectedRoute);
        }


    }
}
