using AngleSharp;

namespace parsing
{
    public class Program
    {
        public static void Main(string[] args)
        {

            while (true)
            {

                Thread.Sleep(1000);
                Console.WriteLine("Введите название сайта для парсинга");
                ParseClass parseClass = new ParseClass();
                //ParsingService parsingService = new ParsingService();
                parseClass._nameSite = "qq"; //Console.ReadLine();
                Console.WriteLine("Введите адрес сайта");
                parseClass._address = "https://en.wikipedia.org/wiki/List_of_The_Big_Bang_Theory_episodes";//Console.ReadLine();
                Console.WriteLine("Введите псевдокласс CSS");
                parseClass._cellSelector = "tr.vevent td:nth-child(3)"; //Console.ReadLine();
                if (parseClass._nameSite.Equals(null) || parseClass._address.Equals(null) || parseClass._cellSelector.Equals(null))
                {
                    Console.WriteLine("Неверный ввод данных");
                    continue;
                }
                Console.WriteLine("Выберите действие с полученными данными");
                Console.WriteLine(" 0 для вывода на консоль");
                Console.WriteLine(" 1 для записи в файл");
                Console.WriteLine(" Любое число для повторного ввода данных");
                int checkFunctionParsing=int.Parse(Console.ReadLine());
                try
                {


                    switch (checkFunctionParsing)
                    {
                        case 0:
                            Console.WriteLine($"Данные с сайта: {parseClass._nameSite}");
                            ParsingService.ReadTitle(parseClass);
                            break;
                            case 1:
                            ParsingService.WriteTitle(parseClass);
                            break;

                    }
                }
                catch
                {
                    Console.WriteLine("Неверный ввод команды");
                    continue;
                }
              


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