using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_system.Value_types
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task2_1_1
            int day;
            string dayString;
            int month;
            string monthString;
            bool isDay;
            bool isMonth;
            
            Console.Write("Enter day(digit): ");
            dayString = Console.ReadLine();
            isDay = Int32.TryParse(dayString, out day);
            Console.Write("Enter month(digit): ");
            monthString = Console.ReadLine();
            isMonth = Int32.TryParse(monthString, out month);

            isMonth = CheckIsMonth(month);
            if (isMonth)
            {
                isDay = CheckIsDay(month, day);
            }
            else
            {
                Console.WriteLine("");
            }

            Console.Clear();

            Console.WriteLine("Entered value day is: {0}", isDay);
            Console.WriteLine("Entered value month is: {0}", isMonth);

            Console.ReadKey();
            #endregion
        }

        #region Methods
        private static bool CheckIsMonth(int month)
        {
            return month > 0 && month <= 12;
        }

        private static bool CheckIsDay(int month, int day)
        {
            int[] daysAmount = new int[] {0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            return day > 0 && day <= daysAmount[month];
        }
        #endregion
    }
}
