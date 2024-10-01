using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.YakimukVV.Sprint2.Task1.V24.Lib
{
    public class DataService : ISprint2Task1V24
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool result1 = (a == b);        
            bool result2 = (a != c);        
            bool result3 = (c < d);         
            bool result4 = (b > d);         
            bool result5 = (a <= d);       
            bool result6 = (b >= c);             

            return new bool[] { result1, result2, result3, result4, result5, result6 };
        }
    }
}
