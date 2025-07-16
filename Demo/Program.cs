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


        }
    }
}
