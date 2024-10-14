using Tyuiu.YakimukVV.Sprint2.Task5.V9.Lib;

namespace Tyuiu.YakimukVV.Sprint2.Task5.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца (от 1 до 12):");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число:");
            int day = int.Parse(Console.ReadLine());

            DataService dataService = new DataService();
            string nextDate = dataService.FindDateOfNextDay(month, day);

            Console.WriteLine($"Следующая дата: {nextDate}");
        }
    }
}
