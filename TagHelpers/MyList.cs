using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassyCafe.TagHelpers
{
    [HtmlTargetElement("ozellistem")]
    public class MyList : TagHelper
    {
        public string[] liste { get; set; }
        public object Stringbuilder { get; private set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.PreContent.SetHtmlContent("ul class='list-group'");
            StringBuilder sb = new StringBuilder();
            foreach (string l in liste)
            {
                sb.Append("<li class='list-group-item'>" + l + "</li>");
            }
            sb.Append("</ul>");
            output.PostContent.SetHtmlContent(sb.ToString());

        }
    }
}
