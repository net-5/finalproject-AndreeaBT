using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conference.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Conference.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("editions", Attributes = ForAttributeName)]
    public class EditionTagHelper : TagHelper
    {
        private readonly IEditionsServices editionsServices;
        private const string ForAttributeName = "asp-for";
        [HtmlAttributeName(ForAttributeName)]
        public ModelExpression For { get; set; }

        public EditionTagHelper(IEditionsServices editionsServices)
        {
            this.editionsServices = editionsServices;
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var allEditions = editionsServices.GetEditions();

            output.TagName = "select";

            output.Attributes.SetAttribute("id", For.Name);
            output.Attributes.SetAttribute("name", For.Name);

            output.Attributes.Add("class", "form-group");

            foreach (var edition in allEditions)
            {
                TagBuilder myOption = new TagBuilder("option")
                {
                    TagRenderMode = TagRenderMode.Normal
                };
                myOption.Attributes.Add("value", edition.Name);
                myOption.InnerHtml.Append(edition.Name);
                output.Content.AppendHtml(myOption);
            }
        }
    }
}
