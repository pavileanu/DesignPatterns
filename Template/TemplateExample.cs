// Template Functions,basically on a method we can have multiple methods one after another an algorithm.
// THIS WOULD BE THE DEFAULT TEMPLATE, then we want to change based on our preferences,
// so we inherit and use virtual methods to change the logic and end up with another alogirthmm result
// Another options is through abstract class and override, same thing


namespace Template
{
    public static class TemplateExample
    {
        public static void Main()
        {
            new Process().Start();

            new Variation1().Start();
            new Variation2().Start();
            new Variation3().Start();       
        }
    }
}
