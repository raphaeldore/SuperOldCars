using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperOldCars.Web.Helpers
{
    public static class ImageHelper
    {
        public static MvcHtmlString PlaceholderCarImage(this HtmlHelper helper, string marque, string modele, int width,
            int heigth)
        {
            string baseUrl = "http://loremflickr.com/{0}/{1}/{2},{3}/all";
            TagBuilder img = new TagBuilder("img");

            img.Attributes.Add("src", string.Format(baseUrl, width, heigth, marque.ToLower(), modele.ToLower()));
            return new MvcHtmlString(img.ToString());
        }

    }
}