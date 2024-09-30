using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.YakimukVV.Sprint2.Task0.V12.Lib
{
    public class DataService : ISprint2Task0V12
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            return new bool[]
            {
                x == y,     
                x != y,     
                x < y,      
                x > y,      
                x <= y,     
                x >= y      
            };
        }
    }
}