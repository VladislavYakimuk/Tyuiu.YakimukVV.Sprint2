using Tyuiu.YakimukVV.Sprint2.Task1.V24.Lib;
namespace Tyuiu.YakimukVV.Sprint2.Task1.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Якимук В. В. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Якимук Владислав Владимирович | ИБКСб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последо *");
            Console.WriteLine("* вательность можно чередовать, но использовать один раз в выражении) и   *");
            Console.WriteLine("* логических операций (|, &, ||, &&, !, ^, последовательность операций не *");
            Console.WriteLine("* должна нарушаться, а также арифметических выражений, которая вернет ло  *");
            Console.WriteLine("* гическую последовательность(массив): (True, False, True, False, True,   *");
            Console.WriteLine("* False), при a = 325, b = 325, c = 242, d = 324                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("* a = 325, b = 325, c = 242, d = 324                                      *");

            int a = 325, b = 325, c = 242, d = 324;

            bool[] results = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
