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
                        ParseClass wikipedia = new ParseClass();
                        wikipedia._nameSite = "Википедия";
                        wikipedia._address = "https://en.wikipedia.org/wiki/List_of_The_Big_Bang_Theory_episodes";
                        wikipedia._cellSelector = "tr.vevent td:nth-child(3)";
                        wikipedia.FunctionParsing(wikipedia);
                        break;
                    case 1:
                        ParseClass wikipediaSecond = new ParseClass();
                        wikipediaSecond._nameSite = "Википедия 2";
                        wikipediaSecond._address = "https://en.wikipedia.org/wiki/List_of_The_Big_Bang_Theory_episodes";
                        wikipediaSecond._cellSelector = "html";
                        wikipediaSecond.FunctionParsing(wikipediaSecond);

                        break;

                }

            }
        }


    }
}