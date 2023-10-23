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
                Console.WriteLine("Выберите действие с полученными данными");
                Console.WriteLine(" 0 для вывода на консоль");
                Console.WriteLine(" 1 для записи в файл");
                Console.WriteLine(" Любое число для повторного ввода данных");
                int checkFunctionParsing = int.Parse(Console.ReadLine());
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
            }
        }


    }
}