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
    public class When_using_the_default_route
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
        public void I_can_get_an_empty_route()
        {
            RouteAssert.HasRoute(routes, "/");
        }

        [Test]
        public void I_can_get_the_home_page_implicitly_route()
        {
            RouteAssert.HasRoute(routes, "/home");
        }

        [Test]
        public void I_can_get_the_home_page_explicitly()
        {
            RouteAssert.HasRoute(routes, "/home/index");
        }

        [Test]
        public void I_can_get_the_about_page_explicitly()
        {
            RouteAssert.HasRoute(routes, "/home/about");
        }

        [Test]
        public void works_with_all_params_specified()
        {
            RouteAssert.HasRoute(routes, "/item/details/42");
        }

        [Test]
        public void I_can_get_the_default_route()
        {
            var expectedRoute = new { controller = "Home", action = "Index", id = 42 };
            RouteAssert.HasRoute(routes, "/home/index/42", expectedRoute);
        }



    }
}
