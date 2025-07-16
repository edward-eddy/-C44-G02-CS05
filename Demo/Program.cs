namespace Demo
{
    internal class Program
    {
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





        }
    }
}
