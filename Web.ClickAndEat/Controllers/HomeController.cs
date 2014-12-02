using Service.ClickAndEat.Api.JustEat.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.ClickAndEat.Models;
using Web.ClickAndEat.ViewModel.Restaurant;

namespace Web.ClickAndEat.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Search(RestaurantViewModel restaurantViewModel)
        {
          //  var justEatClient = new JustEatClient();

          //  justEatClient.Get();

            return View(restaurantViewModel);
        }

        public ActionResult Restaurants()
        {
            return View();
        }
    }
}
