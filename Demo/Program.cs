namespace Demo
{
    internal class Program
    {

        #region Exception Handeling And Protictive Code Functions
        //static void DoSomeCode()
        //{
        //    int X, Y, Z;
        //    X = int.Parse(Console.ReadLine());
        //    Y = int.Parse(Console.ReadLine());

        //    Z = X / Y;

        //    int[] Arr = { 1, 2, 3 };
        //    Arr[99] = 10;
        //}

        static void DoSomeCode()
        {
            try
            {
                int X, Y, Z;
                X = int.Parse(Console.ReadLine());
                Y = int.Parse(Console.ReadLine());

                Z = X / Y;

                int[] Arr = { 1, 2, 3 };
                Arr[99] = 10;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
                // Release | Deallocate | Disconnect | Dispose UnManaged Resource
            }
        }
        static void DoSomeProtictiveCode()
        {
            try
            {
                int X, Y, Z, I;
                do
                {
                    Console.WriteLine("Enter First Number : ");
                }
                while (!int.TryParse(Console.ReadLine(), out X));

                do
                {
                    Console.WriteLine("Enter Second Number : ");
                }
                while (!int.TryParse(Console.ReadLine(), out Y) || Y == 0);

                Z = X / Y;

                do
                {
                    Console.WriteLine("Enter Index Number (0 => 2) : ");
                }
                while (int.TryParse(Console.ReadLine(), out I) || I > 2 || I < 0);


                int[] Arr = { 1, 2, 3 };
                Arr[I] = 10;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        #endregion

        static void Main(string[] args)
        {

            #region Boxing And UnBoxing
            // Boxing And UnBoxing
            // Boxing : Casting From ValueType To ReferenceType
            // UnBoxing : Casting From ReferenceType To ValueType

            //object O1;

            // O1 => Can Refer To Instance Of "Object" Or Any Instance of Any Type

            //O1 = 1;
            //O1 = "Ahmed";

            //O1 = 3;              // Cast From ValueType[int] To RoferenceType[object]       => Boxing
            //O1 = 1.5;            // Cast From ValueType[double] To ReferenceType[object]    => Boxing
            //O1 = 'A';            // Cast From ValueType[char] To ReferenceType[object]      => Boxing
            //O1 = true;           // Cast From ValueType[bool] To ReferenceType[object]      => Boxing
            //O1 = new DateTime(); // Cast From ValueType[DateTime] To ReferenceType[object]  => Boxing


            //int X = 5;
            //object 01 = /*(object)*/ X;

            // Implicit Casting
            // Safe Casting Boxing
            // Parent = Child => Child is Parent
            // Animal = Dog => Dog is Animal

            //object O1 = 3;

            //int X = (int) O1;

            // Explicit Casting
            // UnSafe Casting [May Throw Exception]
            // UnBoxing
            // Dog = (Dog) Animal => Animal is Dog
            // Child = Parent => Parent is  child 
            #endregion

            #region Nullable Types
            // Nullable Types

            // Value Type 
            // Reference Type

            #region Nullable Value Types

            // 1. Nullable Value Types

            //int X = 6;

            //X = null; // not Valid


            // Nullable Value types => Value type Allow Null As a Valid Value

            //Nullable<int> : Allow Int Values + Null As a Valid Value
            //int? Age = 20;

            //Age = null;


            // Nullable<double> : Allow Double Values + Null as a Valid Values
            //double? Salary = 4000.5;

            //Salary = null;

            //int X = 5;

            // Y : Nullable<Int>
            // Y : Allow int Value or Null

            //int? Y = /*(int?)*/ X;

            // Implicit Casting
            // Safe Casting

            //Console.WriteLine(Y);


            //int? X = 5;

            // Y : int
            // Y : Allow int Value Only

            //int Y = (int) X;
            // Explicit Casting
            // May Throw Exception


            // Defensive Code
            //if (X != null)
            //    Y = (int)X;
            //else
            //    Y = 0;

            // ==============

            //if (X is not null)
            //    Y = (int)X;
            //else
            //    Y = 0;

            //============

            //if (X.HasValue)
            //    Y = X.Value;
            //else
            //    Y = 0;

            // ==============

            //Y = X.HasValue ? X.Value : 0;

            // ==============

            // Null Coalescing Operator ??

            //Y = X ?? 0; // Syntax Sugar : X is not null ? X.Value : 0;

            //Console.WriteLine(Y); 
            #endregion


            #region Nullable Reference Types
            // 2. Nullable Reference Types [C# 10.0 | .NET 6.0]

            //string Message = "Hello";
            //Message = null;

            //Console.WriteLine(Message);


            //string Message01 = null;    // Required

            //string? Message02 = null;   // Optional

            //Console.WriteLine(Message01.Length);
            //Console.WriteLine(Message02); 
            #endregion
            #endregion

            #region Null Propagation Operator
            // Null Propagation Operator ?

            //double X = default; // 0
            //char C = default;
            //bool B = default;

            //Console.WriteLine(C);


            //int[] Arr = default; // null

            //int[] Arr = { 1, 2, 3, 4, 5 };


            //for(int i = 0; (Arr is not null) && i < Arr.Length; i++)
            //    Console.WriteLine(Arr[i]);

            /*              OR              */

            //for (int i = 0; i < Arr?.Length; i++)
            //        Console.WriteLine(Arr[i]);


            //Best Practice:

            //if (Arr is not null)
            //{
            //    for (int i = 0; i < Arr.Length; i++)
            //        Console.WriteLine(Arr[i]);
            //}


            // E?.Name // null
            // E?.Department.DeptName

            //int Len = Arr is not null ? Arr.Length : 0;

            //int? Len = Arr?.Length;

            //int Len = Arr?.Length is not null ? Arr.Length : 0;
            //int Len = Arr?.Length ?? -1;

            //Console.WriteLine(Len); 
            #endregion

            #region Exception Handeling And Protictive Code
            // Exception Handeling And Protictive Code

            //DoSomeCode();
            //DoSomeProtictiveCode();

            //Console.WriteLine("Hello After Exception");

            // Exception
            // 1. SystomExcoption
            //   1.1.FormatException
            //   1.2.IndexOutOfRangeException
            //   1.3.NullReferenceException
            //   1.4.ArithmoticException
            //      1.4.1.OverflomException
            //      1.4.2.DivideByZeroException
            // 2. ApplicationException 
            #endregion





        }
    }
}
