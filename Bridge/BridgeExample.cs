// Bridge
// If we have a class that have 2 childs and the 2 childs has other 4 childs, we end up with 7 classes that are dependent
// one of another
// WE NEED DECOUPLE SO THE LOGIC OF the 2 childs should not inherit the logic for the the other 4 child.
// In C#, Instead of having ListInt class and ListString class, we do have GENERICS, List<T>,
// so the type won't interfere with List logic, this making easy to use.

namespace Bridge
{
    public static class BridgeExample
    {
        public static void Main()
        {
            List<int> list = new List<int>();
            List<string> list2 = new List<string>();   

            IEnumerable<int> list3 = new List<int>();
            IEnumerable<string> list4 = new List<string>();

            Console.WriteLine("Bridge between List and Int or List String");
        }
         
    }
}
