using Service.ClickAndEat.Api.JustEat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.ClickAndEat.ViewModel.Shared;

using RestaurantModel = Service.ClickAndEat.Api.JustEat.Model.Restaurant;

namespace Web.ClickAndEat.ViewModel.Restaurant
{
    public class RestaurantViewModel : PagedViewModel
    {
        public PostcodeSearchViewModel PostcodeSearchViewModel { get; set; }

        public IEnumerable<RestaurantModel> Restaurants { get; set; }
    }
}