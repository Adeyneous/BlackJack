using Microsoft.AspNetCore.Razor.TagHelpers;
using BlackJack.Models; // Adjust if your Game model is in a different namespace

namespace BlackJack.TagHelpers
{
    [HtmlTargetElement("hand-header")]
    public class HandHeaderTagHelper : TagHelper
    {
        public Hand Hand { get; set; }
        public bool MustShowTotal { get; set; }
        public string Role { get; set; } // "Dealer" or "Player"

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string headerText = Role;
            if ((Role == "Dealer" && MustShowTotal) || (Role == "Player" && Hand.HasCards))
            {
                headerText = $"{Role}: {Hand.Total}";
            }

            output.TagName = "h5";
            output.Content.SetContent(headerText);
        }
    }

}


