using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text.Encodings.Web;

namespace BlackJack.TagHelpers;

[HtmlTargetElement("game-action-button")]
public class GameActionButtonTagHelper : TagHelper
{
    [HtmlAttributeName("asp-action")]
    public string Action { get; set; }

    [HtmlAttributeName("disabled")]
    public bool IsDisabled { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "form";
        output.Attributes.SetAttribute("method", "post");
        output.Attributes.SetAttribute("asp-action", Action);

        var button = $"<button type='submit' class='btn btn-primary' " +
                     $"{(IsDisabled ? "disabled" : string.Empty)}> " +
                     $"{Action}</button>";

        output.Content.SetHtmlContent(button);
    }
}

