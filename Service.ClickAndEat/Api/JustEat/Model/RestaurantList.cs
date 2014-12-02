using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service.ClickAndEat.Api.JustEat.Model
{
    public class RestaurantList
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
    }
}