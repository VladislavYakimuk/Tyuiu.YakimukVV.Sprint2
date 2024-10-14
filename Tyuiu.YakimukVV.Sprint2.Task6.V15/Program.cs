using Tyuiu.YakimukVV.Sprint2.Task6.V15.Lib;
namespace Tyuiu.YakimukVV.Sprint2.Task6.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService service = new DataService();
            Console.Write("Введите день года (1-365): ");
            int k = int.Parse(Console.ReadLine());
            string dayName = service.FindDayName(k);
            Console.WriteLine($"День {k} является {dayName}.");
        }
    }
}

