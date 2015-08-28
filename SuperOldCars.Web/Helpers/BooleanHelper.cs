using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperOldCars.Web.Helpers
{
    public static class BooleanHelper
    {
        public static string FormatBool(this HtmlHelper html, bool value)
        {
            return html.Encode(value ? "Oui" : "Non");
        }
    }
}