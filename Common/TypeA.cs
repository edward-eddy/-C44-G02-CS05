namespace Common
{

    internal class TypeA
    {
        void Fun01()
        {
            TypeA typeA = new TypeA();

            TypeB typeB = new TypeB(); // Valid

            //typeB.X = 12;   // Invalid : private
            typeB.Y = 13;   // Valid
            typeB.Z = 14;   // Valid
        }
    }
}
