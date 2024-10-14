using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.YakimukVV.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int n, int m)
        {
            int nextDay = n;
            int nextMonth = m;

            switch (m)
            {
                case 1: // Январь
                case 3: // Март
                case 5: // Май
                case 7: // Июль
                case 8: // Август
                case 10: // Октябрь
                case 12: // Декабрь
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

                case 4: // Апрель
                case 6: // Июнь
                case 9: // Сентябрь
                case 11: // Ноябрь
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

                case 2: // Февраль
                    if (n == 28)
                    {
                        nextDay = 1;
                        nextMonth = 3; // Март
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
