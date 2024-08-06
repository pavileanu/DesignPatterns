// Mediator is pattern when multiple objects are dependent of each other. Insted of having a lot of complicated staff,
// we would like to create a Mediator Class to mediate between objects ( LOOK INTO MediatorContext class)

// Mediator class should be inject in every component, and through mediator methods we solve the issue instead
// of having it on the component

// There is Mediator Pattern already implemented in C#

namespace Mediator
{
    public static class MediatorExample
    {
        public static void Main()
        {
            Console.WriteLine("Read the MediatorExample");
        }
    }
}
