using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;

namespace WebApplication1.Models
{
    public static class HTMLHelperExtension
    {
        public static MvcHtmlString Script(this HtmlHelper htmlHelper, string key, Func<object, HelperResult> template)
        {
            htmlHelper.ViewContext.HttpContext.Items[key] = template;
            return MvcHtmlString.Empty;
        }

        public static IHtmlString Script(this HtmlHelper htmlHelper, string key)
        {
            var template = htmlHelper.ViewContext.HttpContext.Items[key] as Func<object, HelperResult>;
            if (template != null)
            {
                htmlHelper.ViewContext.Writer.Write(template(null));
            }
            return MvcHtmlString.Empty;
        }
    }
}