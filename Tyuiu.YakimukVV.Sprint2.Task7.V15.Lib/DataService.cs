using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.YakimukVV.Sprint2.Task7.V15.Lib
{
    public class DataService : ISprint2Task7V15
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            
            if (y < 0)
            {
                return false;
            }

            double distance = Math.Sqrt(x * x + y * y);

            return distance >= 1 && distance <= 2;
        }
    }
}
