using System;

namespace Type_system.Value_types
{
    struct Dog
    {
        public string Name;
        public string Mark;
        public int Age;

        public override string ToString()
        {
            return $"Dog Name is \"{Name}\", Mark: \"{Mark}\", Age: \"{Age}\"";
        }
    }

    class Program
    {
        enum TestCaseStatus
        {
            Pass,
            Fail,
            Blocked,
            WP,
            Unexecuted
        }

        struct RGB
        {
            public byte red;
            public byte green;
            public byte blue;
        }

        enum HTTPError
        {
            Bad_Request = 400,
            Unauthorized = 401,
            Payment_Required = 402,
            Forbidden = 403,
            Not_Found = 404,
            Method_Not_Allowed = 405,
            Not_Acceptable = 406,
            Proxy_Authentication_Required = 407,
            Request_Timeout = 408,
            Conflict = 409,
            Gone = 410,
            Length_Required = 411,
            Precondition_Failed = 412,
            Payload_Too_Large = 413,
            URI_Too_Long = 414,
            Unsupported_Media_Type = 415,
            Range_Not_Satisfiable = 416,
            Expectation_Failed = 417,
            Im_a_teapot = 418,
            Misdirected_Request = 421,
            Unprocessable_Entity = 422,
            Locked = 423,
            Failed_Dependency = 424,
            Upgrade_Required = 426,
            Precondition_Required = 428,
            Too_Many_Requests = 429,
            Request_Header_Fields_Too_Large = 431,
            Unavailable_For_Legal_Reasons = 451
        }

        static void Main(string[] args)
        {
            #region Task2_1_1
            //int day;
            //string dayString;
            //int month;
            //string monthString;
            //bool isDay;
            //bool isMonth;

            //try
            //{
            //    Console.Write("Enter day(digit): ");
            //    dayString = Console.ReadLine();
            //    day = Int32.Parse(dayString);
            //    Console.Write("Enter month(digit): ");
            //    monthString = Console.ReadLine();
            //    month = Int32.Parse(monthString);
            //    isMonth = CheckIsMonth(month);
            //    if (isMonth)
            //    {
            //        isDay = CheckIsDay(month, day);
            //    }
            //    Console.Clear();

            //    Console.WriteLine("Entered value day is: {0}", isDay);
            //    Console.WriteLine("Entered value month is: {0}", isMonth);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Console.ReadKey();
            #endregion

            #region Task2_1_2
            //string digitString;
            //int index;
            //double digit;
            //int firstDigit;
            //int secondDigit;

            //try
            //{
            //    Console.Write("Enter digit: ");
            //    digitString = Console.ReadLine();
            //    index = digitString.IndexOf('.');
            //    digit = double.Parse(digitString);

            //    int val = (int)digit;
            //    double fract = digit - val;

            //    if ((int)(fract * 100) % 10 != 0)
            //    {
            //        firstDigit = (int)(fract * 10);
            //        secondDigit = (int)((fract * 10 - firstDigit) * 10);
            //        Console.WriteLine("\nAddition {0} + {1} = {2}", firstDigit, secondDigit, firstDigit + secondDigit);
            //    }
            //    else
            //    {
            //        Console.WriteLine("\nNot enough digits count");
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Console.WriteLine("\nPress any key...");
            //Console.ReadKey();
            #endregion

            #region Task2_1_3
            //string digitString;
            //string result;
            //int digitValue;

            //try
            //{
            //    Console.Write("Enter digit hour(digit): ");
            //    digitString = Console.ReadLine();
            //    digitValue = Int32.Parse(digitString);

            //    result = GetMessage(digitValue);
            //    Console.WriteLine($"\n{result}");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Console.WriteLine("\nPress any key...");
            //Console.ReadKey();
            #endregion

            #region Task2_2_1
            //TestCaseStatus test1Status = TestCaseStatus.Pass;
            //Console.WriteLine("Test1Status : {0}", test1Status);
            //Console.WriteLine("\nPress any key...");
            //Console.ReadKey();
            #endregion

            #region Task2_2_2
            //RGB white;
            //white.red = 255;
            //white.green = 255;
            //white.blue = 255;

            //RGB black;
            //black.red = 0;
            //black.green = 0;
            //black.blue = 0;

            //Console.WriteLine("White color (R,G,B) = ({0},{1},{2})", white.red, white.green, white.blue);
            //Console.WriteLine("\nBlack color (R,G,B) = ({0},{1},{2})", black.red, black.green, black.blue);

            //Console.WriteLine("\nPress any key...");
            //Console.ReadKey();
            #endregion

            #region HomeWork2_A
            //string firstDigitString;
            //string secondDigitString;
            //string thirdDigitString;
            //float firstDigit;
            //float secondDigit;
            //float thirdDigit;

            //try
            //{
            //    Console.Write("Enter first digit: ");
            //    firstDigitString = Console.ReadLine();
            //    firstDigit = float.Parse(firstDigitString);

            //    Console.Write("Enter second digit: ");
            //    secondDigitString = Console.ReadLine();
            //    secondDigit = float.Parse(firstDigitString);

            //    Console.Write("Enter third digit: ");
            //    thirdDigitString = Console.ReadLine();
            //    thirdDigit = float.Parse(firstDigitString);

            //    Console.Clear();

            //    WriteResult(firstDigit);
            //    WriteResult(secondDigit);
            //    WriteResult(thirdDigit);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Console.WriteLine("\nPress any key...");
            //Console.ReadKey();
            #endregion

            #region HomeWork2_B
            //string firstDigitString;
            //string secondDigitString;
            //string thirdDigitString;
            //int firstDigit;
            //int secondDigit;
            //int thirdDigit;

            //int max;
            //int min;

            //try
            //{
            //    Console.Write("Enter first digit: ");
            //    firstDigitString = Console.ReadLine();
            //    firstDigit = Int32.Parse(firstDigitString);

            //    Console.Write("Enter second digit: ");
            //    secondDigitString = Console.ReadLine();
            //    secondDigit = Int32.Parse(secondDigitString);

            //    Console.Write("Enter third digit: ");
            //    thirdDigitString = Console.ReadLine();
            //    thirdDigit = Int32.Parse(thirdDigitString);

            //    Console.Clear();

            //    if (firstDigit > secondDigit)
            //    {
            //        if (firstDigit > thirdDigit)
            //        {
            //            max = firstDigit;
            //        }
            //        else
            //        {
            //            max = thirdDigit;
            //        }

            //        if (secondDigit > thirdDigit)
            //        {
            //            min = thirdDigit;
            //        }
            //        else
            //        {
            //            min = secondDigit;
            //        }
            //    }
            //    else
            //    {
            //        if (secondDigit > thirdDigit)
            //        {
            //            max = secondDigit;
            //        }
            //        else
            //        {
            //            max = thirdDigit;
            //        }

            //        if (firstDigit > thirdDigit)
            //        {
            //            min = thirdDigit;
            //        }
            //        else
            //        {
            //            min = firstDigit;
            //        }
            //    }
            //    Console.WriteLine("Min value = {0}", min);
            //    Console.WriteLine("Max value = {0}", max);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Console.WriteLine("\nPress any key...");
            //Console.ReadKey();
            #endregion

            #region HomeWork2_C
            //string strDigit;
            //int errCode;
            //bool exists = false;

            //try
            //{
            //    Console.Write("Enter error code(400 - 418): ");
            //    strDigit = Console.ReadLine();
            //    errCode = Int32.Parse(strDigit);
            //    exists = Enum.IsDefined(typeof(HTTPError), errCode);

            //    if (exists)
            //    {
            //        Console.WriteLine("\nEnter error code Enum is: \"{0}\"", Enum.GetName(typeof(HTTPError), errCode));
            //    }
            //    else
            //    {
            //        Console.WriteLine("\nError:\"This error code no in error list\"");
            //    }

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Console.WriteLine("\nPress any key...");
            //Console.ReadKey();
            #endregion

            #region HomeWork2_D
            //Dog myDog;
            //Console.Write("Enter Dog Name: ");
            //myDog.Name = Console.ReadLine();
            //Console.Write("Enter Dog Mark: ");
            //myDog.Mark = Console.ReadLine();

            //try
            //{
            //    Console.Write("Enter Dog Age: ");
            //    myDog.Age = int.Parse(Console.ReadLine());

            //    Console.WriteLine("\n{0}", myDog.ToString());
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}



            //Console.WriteLine("\nPress any key...");
            //Console.ReadKey();
            #endregion
        }

        #region Methods
        private static void WriteResult(float digit)
        {
            bool isValuInRange;
            string result;

            isValuInRange = CheckValueInRange(digit);

            if (isValuInRange)
            {
                result = $"\n{digit} value is in range[-5,5]";
            }
            else
            {
                result = $"\n{digit} value is not in range[-5,5]";
            }
                Console.WriteLine(result);
        }

        private static bool CheckValueInRange(float digit)
        {
            return digit >= -5 && digit <= 5;
        }

        private static bool CheckIsMonth(int month)
        {
            return month > 0 && month <= 12;
        }

        private static bool CheckIsDay(int month, int day)
        {
            int[] daysAmount = new int[] {0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            return day > 0 && day <= daysAmount[month];
        }

        private static string GetMessage(int digitValue)
        {
            if (digitValue >= 0 && digitValue < 6)
            {
                return "Good Night";
            }
            else if (digitValue >= 6 && digitValue < 12)
            {
                return "Good morning";
            }
            else if (digitValue >= 12 && digitValue < 18)
            {
                return "Good Afternoon";
            }
            else if (digitValue >= 18 && digitValue < 24)
            {
                return "Good Evening";
            }
            else
            {
                return "Entered data is wrong";
            }
        }
        #endregion
    }
}
