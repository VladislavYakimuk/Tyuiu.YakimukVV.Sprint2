using Tyuiu.YakimukVV.Sprint2.Task0.V12.Lib;
namespace Tyuiu.YakimukVV.Sprint2.Task0.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Якимук В. В. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Якимук Владислав Владимирович | ИБКСб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последо *");
            Console.WriteLine("* вательность операций не должна нарушаться) и арифметических выражений,  *");
            Console.WriteLine("* которая вернет логическую последовательность(массив): (True, False,     *");
            Console.WriteLine("* True, False, True, False), при x = 1095, y = 475                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("* x = 1095, y = 475                                                       *");
            Console.WriteLine("***************************************************************************");
            
            int x = 1095;
            int y = 475;

            bool[] results = ds.GetCompareOperations(x, y);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"{string.Join(", ", results)}");



        }
    }
}

