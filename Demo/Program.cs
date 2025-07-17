namespace Demo
{
    #region Access Modifiers
    // Access Modifiers: C# Keywords Indicate Accessability Scope
    // 1. private   ------>
    // 2. private protected
    // 3. protected 
    // 4. internal  ------>
    // 5. internal protected
    // 6. public    ------>


    // What Can Write Inside The Namespace?
    // 1. Class
    // 2. Struct
    // 3. Interface
    // 4. Enum


    // Access Modifiers Inside The Namespace
    // 1. enternal  :   Accessable At Tha Same Project
    // 2. public    :   Everywhere

    // Default Access Modifier Inside The Namespace Is "internal"


    // What Can Write Inside Tha Class Or Struct
    // 1. Attributes [Filed - Member Variable]
    // 2. Properties [Full Property - Automatic Property - Special Property(Indexer)]
    // 3. Methods - Functions
    // 4. Event

    // Access Modifiers Inside The Class
    // 1. private   
    // 2. private protected
    // 3. protected 
    // 4. internal  
    // 5. internal protected
    // 6. public    


    // Access Modifiers Inside The Struct
    // 1. private   : Inside The Same Class
    // 2. internal  : Inside The Same Project
    // 3. public    : Everywhere

    // Default Access Modifier Inside The Class Or Struct Is "private"

    // What Can Write Inside The Interface
    // 1. Signature Of Methods [ Return Type - Name - Parameter]
    // 2. Signature Of Property
    // 3. Default Implemented Method [C# 8.0 .NET Core 3.1]

    // All Access Modifiers Except "private" -> with Default Implemented Method

    // Default Access Modifiers Inside The Interface is "public" 
    #endregion

    #region Enums
    enum Season : byte
    {
        Spring = 250,
        Winter,
        Summer,
        Autumn
    }

    enum Weekday
    {
        Saturday,
        Sunday,
        Monday,
        Tuseday,
        Wednesday,
        Thursday,
        Friday
    }

    enum Gender
    {
        Male,
        Female
    }
    #endregion

    [Flags]
    enum Permission
    {
        Read = 8,
        Write = 4,
        Execute = 2,
        Delete = 1
    }

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

            #region Access Modifiers
            // Class Library

            //Common.TypeA typeA = new Common.TypeA(); // Invalid -> TypeA class is internal

            //Common.TypeB typeB = new Common.TypeB();    // Valid -> TypeB class is public

            // typeB.X = 12;     // Invalid private
            // typeB.Y = 13;     // Invalid internal
            //typeB.Z = 14;        // Valid  
            #endregion

            #region Enum
            // Enum : Value Types


            //Season S01 = Season.Autumn;

            //S01 = Season.Summer;


            //Console.WriteLine(S01);

            // Stack Memory

            // CLR Represent Enum As Integer Value In Memory

            //Gender G01 = Gender.Male;
            //Gender G01 = (Gender) 1;

            //Console.WriteLine(G01);


            //Gender G01 = (Gender) Enum.Parse(typeof(Gender), Console.ReadLine(), true);

            //Gender G01;
            //Enum.TryParse(typeof(Gender), Console.ReadLine(), true, out object O1);

            //G01 = (Gender) O1;

            //Console.WriteLine(G01); 
            #endregion

            #region Advanced Enum
            //Permission Per01 = Permission.Read;
            //Per01 ^= Permission.Delete; // Toggle

            //Per01 |= Permission.Delete; // Add Permession

            //Per01 &= ~(Permission.Delete); // ~ Not Bitwise

            // & -> Check Permission

            //if((Per01&Permission.Delete) == Permission.Delete)
            //    Console.WriteLine("Exists");
            //else
            //    Console.WriteLine("Not Exists");

            //    Console.WriteLine(Per01); 
            #endregion
        }
    }
}
