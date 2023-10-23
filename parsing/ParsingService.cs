using AngleSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace parsing
{
    public static class ParsingService
    {
        
        public static async Task ReadTitle(ParseClass site)
        {
            
            foreach (var title in await Parsing(site))
            {
                Console.WriteLine(title);
            }
            
        }

       

        public static async Task WriteTitle(ParseClass site)
        {
            
            //var titles = Parsing(site);
            foreach(var title in await Parsing(site))
            {
                ParsingJsonClass parsingJson = new ParsingJsonClass(title);
                parsingJson.CreateJson(parsingJson);

            }

            

        }

       
        public static async Task<IEnumerable<string>> Parsing(ParseClass site)
        {
            
            var config = Configuration.Default.WithDefaultLoader();
            var context = BrowsingContext.New(config);

            var document = await context.OpenAsync(site._address);
            var cells = document.QuerySelectorAll(site._cellSelector);
            var titles = cells.Select(m => m.TextContent);
            return titles;
        }

    }
}
