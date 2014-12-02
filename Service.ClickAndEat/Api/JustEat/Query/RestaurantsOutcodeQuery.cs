using Service.ClickAndEat.Api.JustEat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service.ClickAndEat.Api.JustEat.Query
{
    public class RestaurantsOutcodeQuery : JustEatQuery
    {
        public RestaurantsOutcodeQuery()
        {
        }

        public IEnumerable<Restaurant> Get(string outcode, int page, int pageSize)
        {
            if(outcode.Length > 0){;
                var allRestaurants = JustEatClient.Get<RestaurantList>(string.Format("restaurants?q={0}", outcode)).Restaurants;

                if (allRestaurants != null)
                {
                    /*Hardwire sorting by rating, which could be abstracted in next iteration of app
                      to react to different filter options
                     */
                    var allRestaurantsSorted = allRestaurants.OrderByDescending(r => r.RatingStars);
                    return PagedResult<Restaurant>(allRestaurantsSorted, page, pageSize);
                }

                return new List<Restaurant>();
            }

            return new List<Restaurant>();         
        }
    }
}