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
        }
    }
}
