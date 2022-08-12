using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace WebUI.HtmlHelpers
{/// <summary>
/// Extension method html helper için araştır.
/// </summary>
    public static class CustomHelpers
    {
        public static HtmlString TextBoxFor<TModel, TValue>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TValue>> expression, bool isReadOnly)
        {
            HtmlString html = default(HtmlString);
            if (isReadOnly)
            {
                html = (HtmlString)HtmlHelperInputExtensions.TextBoxFor(htmlHelper, expression, new { @class = "readOnly", @readonly = "read-only" });
            }
            else
            {
                html = (HtmlString)HtmlHelperInputExtensions.TextBoxFor(htmlHelper, expression);
            }
            return html;
        }
        public static HtmlString yusuf<TModel, TValue>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TValue>> expression, bool isReadOnly)
        {
            HtmlString html = default(HtmlString);
            if (isReadOnly)
            {
                html = (HtmlString)HtmlHelperInputExtensions.TextBoxFor(htmlHelper, expression, new { @class = "readOnly", @readonly = "read-only" });
            }
            else
            {
                html = (HtmlString)HtmlHelperInputExtensions.TextBoxFor(htmlHelper, expression);
            }
            return html;
        }
    }
}
