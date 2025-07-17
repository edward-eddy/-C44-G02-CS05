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
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part02

            #region Q01
            /*
            Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. 
            Then, write a C# program that prints out all the days of the week using this enum.
             */

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine((WeekDays)i);
            }
            #endregion
        }
    }
}
