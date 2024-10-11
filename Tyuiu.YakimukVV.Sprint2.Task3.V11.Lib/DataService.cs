using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.YakimukVV.Sprint2.Task3.V11.Lib
{
    public class DataService : ISprint2Task3V11
    {
        public double Calculate(double x)
        {
            double result;
            if (x > 0)
            {
                result = x + Math.Pow((x - 15) / (x - 19), x);
            }
            else if (x == 0)
            {
                result = (Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12);
            }
            else if (x < 0 && x > -15)
            {
                result =  Math.Pow(1 + (1 / Math.Pow(x, 2)), x);
            }
            else if (x < -15)
            {
                result =  x + 10 * x - (1 / x);
            }
            else
            {
                throw new ArgumentException("Некорректное значение x.");
            }
            return Math.Round(result, 3);
        }
    }
}
