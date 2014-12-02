using Service.ClickAndEat.Api.JustEat.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service.ClickAndEat.Api.JustEat.Query
{
    public class JustEatQuery
    {
        protected JustEatClient JustEatClient { get; set; }

        public JustEatQuery()
        {
            JustEatClient = new JustEatClient();
        }

        protected IEnumerable<T> PagedResult<T>(IEnumerable<T> results, int page, int pageSize)
        {
            int i = 0;
            var pagedResults = from item in results
                     group item by i++ % pageSize into part
                     select part.AsEnumerable();

            var pagedResultsArray = pagedResults.ToArray();

            return pagedResultsArray[page - 1];
        }
    }
}