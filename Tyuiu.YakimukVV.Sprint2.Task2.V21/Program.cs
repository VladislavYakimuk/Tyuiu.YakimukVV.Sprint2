using Tyuiu.YakimukVV.Sprint2.Task2.V21.Lib;

namespace Tyuiu.YakimukVV.Sprint2.Task2.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату X: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату Y: ");
            int y = int.Parse(Console.ReadLine());

            DataService dataService = new DataService();

            bool result = dataService.CheckDotInShadedArea(x, y);

            if (result)
            {
                Console.WriteLine($"Точка ({x}, {y}) находится в заштрихованной области.");
            }
            else
            {
                Console.WriteLine($"Точка ({x}, {y}) не находится в заштрихованной области.");
            }
        }
    }
}
