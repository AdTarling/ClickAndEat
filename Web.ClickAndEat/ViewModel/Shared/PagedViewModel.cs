using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.ClickAndEat.ViewModel.Shared
{
    public class PagedViewModel
    {
        /*
         * Hardwire page 1 into view model for purpose of interview application.
            This could be used by a partial to determine which page the user is on,
         * and updated depending on the user's page choice.
        */
        public int Page
        {
            get { return 1; }
            set { }
        }

        //As above
        public int PageSize 
        {
            get { return 10; }
            set { }
        }
    }
}