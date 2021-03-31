using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SharpenTheSaw.Models.ViewModels;

namespace SharpenTheSaw.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-info")]
    public class TeamListTagHelper : TagHelper
    {
        private IUrlHelperFactory TeamListInfo;

        public TeamListTagHelper(IUrlHelperFactory uhf)
        {
            TeamListInfo = uhf;
        }

        public IndexViewModel TeamListPageInfo { get; set; }

        // Our own dictionary (key value pairs) that we are creating
        [HtmlAttributeName(DictionaryAttributePrefix = "page-url-")]
        public Dictionary<string, object> KeyValuePairs { get; set; } = new Dictionary<string, object>();

        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext VC { get; set; }

        // Variables for dynamic team list styling

        public bool TeamClassesEnabled { get; set; } = false;
        public string TeamPageClass { get; set; }
        public string TeamPageClassNormal { get; set; }
        public string TeamPageClassSelected { get; set; }

        // Function for page styling
        //public override void Process(TagHelperContext context, TagHelperOutput output)
        //{
        //    IUrlHelper urlHelp = TeamListInfo.GetUrlHelper(VC);

        //    TagBuilder finishedTag = new TagBuilder("div");

        //    for (int i = 1; i !== TeamListPageInfo.TeamName; i++)
        //    {
        //        TagBuilder individualTag = new TagBuilder("a");

        //        // -- Start Dynamic Paginaiton Styling --
        //        if (PageClassesEnabled)
        //        {
        //            individualTag.AddCssClass(PageClass);
        //            individualTag.AddCssClass(i == PageInfo.CurPage ? PageClassSelected : PageClassNormal);
        //        }
        //        // End 
        //        KeyValuePairs["pageNum"] = i;

        //        individualTag.Attributes["href"] = urlHelp.Action("Index", KeyValuePairs);
        //        individualTag.InnerHtml.Append(i.ToString());

        //        finishedTag.InnerHtml.AppendHtml(individualTag);
        //    }
        //    output.Content.AppendHtml(finishedTag.InnerHtml);
        //}

    }
}
