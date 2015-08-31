using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperOldCars.Web.Helpers
{
    public static class InputHelper
    {
        public static IEnumerable<SelectListItem> GetYearRangeList(this HtmlHelper html, int numberOfYears)
        {
            List<SelectListItem> years = new List<SelectListItem>();

            DateTime currentDate = DateTime.Now;

            for (int i = currentDate.Year; i >= currentDate.AddYears(-numberOfYears).Year; i--)
            {
                years.Add(new SelectListItem
                {
                    Text = i.ToString(),
                    Value = i.ToString()
                } );
            }

            return years;

        }
    }
}