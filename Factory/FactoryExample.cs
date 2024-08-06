namespace Factory
{
    public static class FactoryExample
    {
        public static void Main()
        {
            // Composition and inversion
            // 1) Here is implemented abstract factory where we have an interface that have a button create method
            // 2) This method can be implemented by multiple factories, button for Android, IOS. (classes)
            // 3) Last thing is INVERSION OF CONTROL, inside another class let s say a Body class, we do want 1 button
            // so in the constructor  of the class WE INJECT THE FACTORY, THEN THE FACTORY CREATES THE BUTTON, 
            // AND FOR EXTENSIBILITY WE USE THE INTERFACE, SO WE CAN CHANGE WHENEVER WE NEED ANOTHER FACTORY

            IButtonFactory androidFactory = new Android();
            IButtonFactory IOSFacotry = new IOS();

            var androidButton = androidFactory.CreateButton();
            var iosButton = IOSFacotry.CreateButton();

            Console.WriteLine(androidButton.value);
            Console.WriteLine(iosButton.value);

            // Inheritance Factory
            // Diferent from composition we create an abstract class that is needed to be inherited
            // THE FACTORY IS NOT THE CLASS, ONLY THE METHOD, AND WE USE THAT METHOD IN THE CONSTRUCTOR
            // ALL CLASES THAT NEED TO USE THE FACTORY NEEDS TO IMPLEMENT THE ABSTRACT CLASS
            // VERY RIGID, DON T LIKE

            var header = new Header();
            var body = new Body();

            Console.WriteLine(header.button.value);
            Console.WriteLine(body.button.value);
        }
    }

}
