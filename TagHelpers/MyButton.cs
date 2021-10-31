using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlassyCafe.TagHelpers
{
    [HtmlTargetElement("button")]
    public class MyButton : TagHelper
    {
        public string tip { get; set; } 
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class", "btn btn-" + tip);
        }

    }
}
