using AngleSharp;

namespace parsing
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Выберите сайт для парсинга");
                int NumberOfSiteSelection = int.Parse(Console.ReadLine());
                switch (NumberOfSiteSelection)
                {
                    case 0:
                        ParseClass wikipedia = new ParseClass("Википедия",
                            "https://en.wikipedia.org/wiki/List_of_The_Big_Bang_Theory_episodes",
                            "tr.vevent td:nth-child(3)");
                        wikipedia.FunctionParsing(wikipedia);
                        break;
                    case 1:
                        break;

                }

            }
        }


    }
}