using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Html.Dom;

namespace Parser.Core.Habra
{
    class HabraParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            var list  = new List<string>();
            //tm-article-snippet__title-link
            IEnumerable<AngleSharp.Dom.IElement>? items = document.QuerySelectorAll("div").Where(item => item.ClassName != null && item.ClassName.Contains("card-item__title"));

            foreach(var item in items)
            {
                list.Add(item.TextContent);
            }

            return list.ToArray();
        }
    }
}
