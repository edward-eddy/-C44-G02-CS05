namespace Assignment
{
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    enum Seasons
    {
        Spring = 1,
        Summer,
        Autumn,
        Winter
    }
    enum Months
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    [Flags]
    enum Permission
    {
        Read = 8,
        Write = 4,
        Execute = 2,
        Delete = 1
    }
    enum Colors
    {
        Red,
        Green,
        Blue
    }

    internal class Program
    {
        static void SeasonRange(Seasons Season)
        {
            int MonthStart = (int)Season * 3;
            Console.WriteLine($"\nMonth Range for {Season} is : ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{(Months)MonthStart++} ");
                MonthStart = (int)MonthStart == 13 ? 1 : MonthStart;
            }
        }
        static void Main(string[] args)
        {
            // Part02

            #region Q01
            /*
            Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. 
            Then, write a C# program that prints out all the days of the week using this enum.
             */

            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine((WeekDays)i);
            //}
            #endregion

            #region Q02
            /*
             Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. 
            Write a C# program that takes a season name as input from the user and displays the corresponding month range 
            for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , 
            winter December to February)
            */

            //object SeasonObj;

            //do
            //{
            //    Console.Write("Enter the Season: ");
            //} while (!Enum.TryParse(typeof(Seasons), Console.ReadLine(), true, out SeasonObj) || (int)SeasonObj > 4 || (int)SeasonObj < 1);

            //SeasonRange((Seasons)SeasonObj);
            #endregion

            #region Q04
            /*
                Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.

                Create Variable from previous Enum to Add and Remove Permission from variable, 
                check if specific Permission is existed inside variable
            */

            //Permission Per01 = Permission.Read;
            //Per01 ^= Permission.Write; // Toggle to Add and Remove Permission from variable

            //// Check if specific Permission is existed inside variable
            //Console.WriteLine((Per01 & Permission.Write) == Permission.Write);      // True
            //Console.WriteLine((Per01 & Permission.Execute) == Permission.Execute);  // False

            #endregion

            #region Q05
            /*
                Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. 
                Write a C# program that takes a color name as input from the user and displays a message indicating 
                whether the input color is a primary color or not.
            */
            //object ColorObj;

            //Console.Write("Enter the Color: ");

            //if (Enum.TryParse(typeof(Colors), Console.ReadLine(), true, out ColorObj))
            //    Console.WriteLine($"{ColorObj} is a primary color");
            //else
            //    Console.WriteLine("The color you entered is not a primary color");
            #endregion
        }
    }
}
