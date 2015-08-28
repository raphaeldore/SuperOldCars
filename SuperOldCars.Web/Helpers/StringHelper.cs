using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperOldCars.Web.Helpers
{
    public static class StringHelper
    {
        public static string FormatMoney(this HtmlHelper html, decimal amount)
        {
            return string.Format("{0:c}", amount);
        }
    }
}