using Microsoft.AspNetCore.Razor.TagHelpers;

namespace LojasMoveis.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        public string Endereco { get; set; } = string.Empty;
        public string Conteudo { get; set; } = string.Empty;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailto:" + Endereco);
            output.Content.SetContent(Conteudo);
        }
    }
}
