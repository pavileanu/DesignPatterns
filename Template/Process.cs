namespace Template
{
    public class Process
    {
        // template method
        public void Start()
        {
            Step1();
            Step2();
            Step3();
        }

        protected virtual void Step1() => Console.WriteLine("Step 1");
        protected virtual void Step2() => Console.WriteLine("Step 2");
        protected virtual void Step3() => Console.WriteLine("Step 3");
    }

    public class Variation1 : Process
    {
        protected override void Step1() => Console.WriteLine("Step 1 Adapted");
    }

    public class Variation2 : Process
    {
        protected override void Step3() => Console.WriteLine("Step 3 Adapted");
    }

    public class Variation3 : Process
    {
        protected override void Step1() => Console.WriteLine("Step 1 Mega Adapted");

        protected override void Step2() => Console.WriteLine("Step 2 Adapted");
    }
}
