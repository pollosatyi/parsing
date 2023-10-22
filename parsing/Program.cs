using AngleSharp;

namespace parsing
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            while (true)
            {


                Console.WriteLine("Введите название сайта для парсинга");
                ParseClass parseClass = new ParseClass();
                parseClass._nameSite = Console.ReadLine();
                Console.WriteLine("Введите адрес сайта");
                parseClass._address = Console.ReadLine();
                Console.WriteLine("Введите псевдокласс CSS");
                parseClass._cellSelector = Console.ReadLine();
                if (parseClass._nameSite.Equals(null) || parseClass._address.Equals(null) || parseClass._cellSelector.Equals(null))
                {
                    Console.WriteLine("Неверный ввод данных");
                    continue;
                }
                parseClass.FunctionParsing(parseClass);
                //int NumberOfSiteSelection = int.Parse(Console.ReadLine());
                //switch (NumberOfSiteSelection)
                //{
                //    case 0:
                //        ParseClass wikipedia = new ParseClass();
                //        wikipedia._nameSite = "Википедия";
                //        wikipedia._address = "https://en.wikipedia.org/wiki/List_of_The_Big_Bang_Theory_episodes";
                //        wikipedia._cellSelector = "tr.vevent td:nth-child(3)";
                //        wikipedia.FunctionParsing(wikipedia);
                //        break;
                //    case 1:
                //        ParseClass wikipediaSecond = new ParseClass();
                //        wikipediaSecond._nameSite = "Википедия 2";
                //        wikipediaSecond._address = "https://en.wikipedia.org/wiki/List_of_The_Big_Bang_Theory_episodes";
                //        wikipediaSecond._cellSelector = "#mw-content-text > div.mw-parser-output > h2:nth-child(8) > span.mw-editsection";
                //        wikipediaSecond.FunctionParsing(wikipediaSecond);

                //        break;

                //}

            }
        }


    }
}