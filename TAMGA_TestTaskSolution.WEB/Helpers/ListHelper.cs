using Application.Services.DTOs.People;
using System;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace TAMGA_TestTaskSolution.WEB.Helpers
{
    public static class ListHelper
    {

        public static MvcHtmlString PhoneNumberFor(this HtmlHelper html, Expression<Func<UserDTO, string>> predicate, object htmlAttributes = null)
        {
            
            TagBuilder input = new TagBuilder("input");

            input.Attributes.Add("name", "Phonenumber");
            input.Attributes.Add("value", "+380");
            input.MergeAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
            return new MvcHtmlString(input.ToString());
        }
    }
}