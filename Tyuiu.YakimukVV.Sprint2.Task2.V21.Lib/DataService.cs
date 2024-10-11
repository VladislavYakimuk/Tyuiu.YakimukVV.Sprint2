using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.YakimukVV.Sprint2.Task2.V21.Lib
{
    public class DataService : ISprint2Task2V21
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((x >= 2 && x <= 3 && y == 3) ||
                (x == 2 && y >= 3 && y <= 6) ||
                (x >= 3 && x <= 6 && y == 5) ||
                (x >= 9 && x <= 11 && y == 5) ||
                (x >= 3 && x <= 11 && y == 6) ||
                (x >= 9 && x <= 12 && y == 7) ||
                (x >= 10 && x <= 12 && y == 8) ||
                (x == 12 && y >= 9 && y <= 11) ||
                (x >= 11 && x <= 12 && y == 10))
            {
                return true;
            }
            return false;
        }
    }
}
