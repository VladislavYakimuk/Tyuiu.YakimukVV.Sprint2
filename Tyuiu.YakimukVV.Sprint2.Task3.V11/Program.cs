using Tyuiu.YakimukVV.Sprint2.Task3.V11.Lib;
namespace Tyuiu.YakimukVV.Sprint2.Task3.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                DataService ds = new DataService();
                Console.Write("Введите значение x: ");
                double x = Convert.ToDouble(Console.ReadLine());

                try
                {
                    double y = ds.Calculate(x);
                    Console.WriteLine($"Результат: {y}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
        }   
    }
}
