namespace Factory
{
    interface IButtonFactory
    {
        Button CreateButton();
    }

    public class Android : IButtonFactory
    {
        public Button CreateButton()
        {
            return new Button()
            {
                value = "Submit Android",
                color = "Blue"
            };
        }
    }

    public class IOS : IButtonFactory
    {
        public Button CreateButton()
        {
            return new Button()
            {
                value = "Submit IOS",
                color = "Teal"
            };
        }
    }
}
