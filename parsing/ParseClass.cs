using AngleSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parsing
{
    public class ParseClass
    {
        public string _nameSite { get; set; }

        public string _address { get; set; }

        public string _cellSelector { get; set; }

        public ParseClass()
        {
            
        }

        public async Task FunctionParsing(ParseClass site)
        {
            Console.WriteLine(site._nameSite);
            var config = Configuration.Default.WithDefaultLoader();
            var context = BrowsingContext.New(config);

            var document = await context.OpenAsync(site._address);
            var cells = document.QuerySelectorAll(site._cellSelector);
            var titles = cells.Select(m => m.TextContent);

            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }

        }
    }


}
