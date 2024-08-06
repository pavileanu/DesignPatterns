namespace Factory
{
    public abstract class Element
    {
        public abstract Button CreateButton(); //factory method

        public Button button;

        public Element()
        {
            button = CreateButton();
        }

    }

    public class Body : Element
    {
        public override Button CreateButton()
        {
            return new Button()
            {
                value = "Body Button",
                color = "Black"
            };
        }
    }

    public class Header : Element
    {
        public override Button CreateButton()
        {
            return new Button()
            {
                value = "Header Button",
                color = "Black"
            };
        }
    }

}
