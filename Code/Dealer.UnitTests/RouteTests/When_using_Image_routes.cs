using System.Net.Http;
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

namespace Dealer.UnitTests.RouteTests
{
    [TestFixture]
    public class When_using_Image_routes
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
        public void I_can_get_the_image_controller_to_download_a_thumbnail()
        {
            var values = new { controller = "Image", action = "Download", size = "thumbnail", name = "Load-Trail-10-23-hydraulic-lift-dump.jpg", id = 387 };
            var expected = IDictionaryProvider.ConvertToDictionary(values);
            RouteAssert.HasRoute(routes, "~/Image/thumbnail/387/Load-Trail-10-23-hydraulic-lift-dump.jpg", HttpMethod.Get, expected);
        }

        [Test]
        public void Image_id_must_be_numeric()
        {
            RouteAssert.NoRoute(routes, "~/Image/thumbnail/abc/Load-Trail-10-23-hydraulic-lift-dump.jpg");
        }




    }
}
