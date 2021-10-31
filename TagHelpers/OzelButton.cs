using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlassyCafe.TagHelpers
{
    [HtmlTargetElement("GonderenButton")]
    public class OzelButton : TagHelper
    {
        public string clasadi { get; set; }
        public string butontipi { get; set; } = "submit";
        public string renk { get; set; } = "#000";
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Attributes.SetAttribute("class", "btn btn-" + clasadi);
            output.Attributes.SetAttribute("type", butontipi);
            output.Attributes.SetAttribute("style", "color:" + renk);
            output.Content.SetContent(butontipi == "submit" ? "Gönder" : "Tıkla");

        }

    }
}
