using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.ClickAndEat.ViewModel.Shared
{
    public class PostcodeSearchViewModel
    {
        [Required(ErrorMessage = "Please enter postcode")]
        [DataType(DataType.PostalCode)]
        [RegularExpression(@"(GIR 0AA)|((([A-Z-[QVX]][0-9][0-9]?)|(([A-Z-[QVX]][A-Z-[IJZ]][0-9][0-9]?)|(([A-Z-[QVX‌​]][0-9][A-HJKSTUW])|([A-Z-[QVX]][A-Z-[IJZ]][0-9][ABEHMNPRVWXY]))))\s?[0-9][A-Z-[C‌​IKMOV]]{2})",
                            ErrorMessage = "Please enter valid postcode")]
        public string PostCode { get; set; }
    }
}