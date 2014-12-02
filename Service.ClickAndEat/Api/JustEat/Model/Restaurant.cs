using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service.ClickAndEat.Api.JustEat.Model
{
    public class Restaurant
    {
        public String Name { get; set; }
        public Double RatingStars { get; set; }
        public IEnumerable<CuisineType> CuisineTypes { get; set; }
    }
}