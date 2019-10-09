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
    [HtmlTargetElement("sponsors", Attributes = ForAttributeName)]
    public class SponsorsTagHelper : TagHelper
    {
        private readonly ISponsorService sponsorService;
        private const string ForAttributeName = "asp-for";
        [HtmlAttributeName(ForAttributeName)]
        public ModelExpression For { get; set; }
        public SponsorsTagHelper(ISponsorService sponsorServices)
        {
            this.sponsorService = sponsorServices;
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var allSponsors = sponsorService.GetAllSponsors();
            output.TagName = "select";
            output.Attributes.SetAttribute("id", For.Name);
            output.Attributes.SetAttribute("name", For.Name);
            output.Attributes.Add("class", "form-group");
            foreach (var sponsor in allSponsors)
            {
                TagBuilder myOption = new TagBuilder("option")
                {
                    TagRenderMode = TagRenderMode.Normal
                };
                myOption.Attributes.Add("value", sponsor.Name);
                myOption.InnerHtml.Append(sponsor.Name);
                output.Content.AppendHtml(myOption);
            }
        }
    }
}
