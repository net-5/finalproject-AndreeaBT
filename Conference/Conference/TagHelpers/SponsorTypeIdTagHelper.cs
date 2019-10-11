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
    [HtmlTargetElement("sponsorTypeId", Attributes = ForAttributeName)]
    public class SponsorTypeIdTagHelper : TagHelper
    {
        private readonly ISponsorTypesService sponsorTypesService;
        private const string ForAttributeName = "asp-for";
        [HtmlAttributeName(ForAttributeName)]
        public ModelExpression For { get; set; }
        public SponsorTypeIdTagHelper(ISponsorTypesService sponsorTypesServices)
        {
            this.sponsorTypesService = sponsorTypesServices;
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var allSponsorTypes = sponsorTypesService.GetAllSponsorTypes();
            output.TagName = "select";
            output.Attributes.SetAttribute("id", For.Name);
            output.Attributes.SetAttribute("name", For.Name);
            output.Attributes.Add("class", "form-group");
            foreach (var sponsorTypeId in allSponsorTypes)
            {
                TagBuilder myOption = new TagBuilder("option")
                {
                    TagRenderMode = TagRenderMode.Normal
                };
                myOption.Attributes.Add("value", sponsorTypeId.Id.ToString());
                myOption.InnerHtml.Append(sponsorTypeId.Id.ToString());
                output.Content.AppendHtml(myOption);
            }
        }
    }
}
