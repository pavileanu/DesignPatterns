// Visitor Pattern solve when there are to many operation done on a class ( different objects ). (Objects should be 
// somehow low, per example here in this example operations are GetThings, UpdateThings ... and the different objects
// are exacly the DataBase providers (Mysql, SqlServer, Redis, ...)

// Visitor is the concept when an action should be done on a specific object, IT IS SAID THAT OUR OPERATION/METHOD
// VISIT THE ELEMENT/OBJECT, also when visiting we need to pass the element/object to know what action we should do
// ( visitor.Visit(this)  where this is the place )

namespace Visitor
{
    public static class VisistorExample
    {
        public static void Main()
        {
            IRepository repo = new Postgres();
            var operation = new GetInt();
            repo.Visit(operation);
            Console.WriteLine(operation.Result);
        }
    }
}
