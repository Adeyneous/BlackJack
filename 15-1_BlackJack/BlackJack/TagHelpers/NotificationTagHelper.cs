// File: NotificationTagHelper.cs
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text.Encodings.Web;

namespace BlackJack.TagHelpers  // Adjust the namespace as per your project structure
{
    [HtmlTargetElement("notification-message")]
    public class NotificationTagHelper : TagHelper
    {
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var tempData = ViewContext.TempData;

            if (tempData.ContainsKey("message"))
            {
                var message = tempData["message"]?.ToString();
                var background = tempData["background"] as string ?? "default";

                output.TagName = "h4";
                output.Attributes.SetAttribute("class", $"bg-{background} text-white p-2");
                output.Content.SetHtmlContent(HtmlEncoder.Default.Encode(message));
            }
            else
            {
                output.SuppressOutput();
            }
        }
    }
}


