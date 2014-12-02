using Service.ClickAndEat.Api.JustEat.Client;
using Service.ClickAndEat.Api.JustEat.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.ClickAndEat.Models;
using Web.ClickAndEat.ViewModel.Restaurant;

namespace Web.ClickAndEat.Controllers
{
    public class RestaurantController : Controller
    {
        //
        // GET: /Restaurant/

        public ActionResult Search(RestaurantViewModel restaurantViewModel)
        {
            

            return View(restaurantViewModel);
        }

        public ActionResult Restaurants(RestaurantViewModel restaurantViewModel)
        {
            var restaurantOutcodeQuery = new RestaurantsOutcodeQuery();

            var page = restaurantViewModel.Page;
            var pageSize = restaurantViewModel.PageSize;

            var restaurantsPage = restaurantOutcodeQuery.Get("se19", page, pageSize);

            restaurantViewModel.Restaurants = restaurantsPage;

            return View(restaurantViewModel);
        }

    }
}
