using Tyuiu.YakimukVV.Sprint2.Task4.V4.Lib;

namespace Tyuiu.YakimukVV.Sprint2.Task4.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y:");
            double y = Convert.ToDouble(Console.ReadLine());

            DataService dataService = new DataService();
            double result = dataService.Calculate(x, y);

            Console.WriteLine($"Результат: {result}");
        }
    }
}
