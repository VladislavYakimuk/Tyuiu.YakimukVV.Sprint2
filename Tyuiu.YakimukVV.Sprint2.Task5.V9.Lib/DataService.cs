using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.YakimukVV.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            int nextDay = n;
            int nextMonth = m;

            switch (m)
            {
                case 1: 
                case 3: 
                case 5: 
                case 7: 
                case 8: 
                case 10: 
                case 12: 
                    if (n == 31)
                    {
                        nextDay = 1;
                        nextMonth = (m == 12) ? 1 : m + 1; 
                    }
                    else
                    {
                        nextDay++;
                    }
                    break;

                case 4: 
                case 6: 
                case 9:
                case 11: 
                    if (n == 30)
                    {
                        nextDay = 1;
                        nextMonth = m + 1;
                    }
                    else
                    {
                        nextDay++;
                    }
                    break;

                case 2: 
                    if (n == 28)
                    {
                        nextDay = 1;
                        nextMonth = 3; 
                    }
                    else
                    {
                        nextDay++;
                    }
                    break;

                default:
                    throw new ArgumentException("Некорректный номер месяца.");
            }

            return $"{nextDay:D2}.{nextMonth:D2}";
        }
    }
}
