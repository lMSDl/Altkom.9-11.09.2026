namespace DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    internal class TextBox : Container
    {
        private string text = string.Empty;

        public string Text
        {
            get => text;
            set
            {
                text = value;
                Console.WriteLine($"{Name} zmienił wartość na {value}");
            }
        }

        protected override void Click(bool handled)
        {
            if (!handled)
            {
                Console.WriteLine($"{Name} ustawił focus");
                handled = true;
            }
            base.Click(handled);
        }
    }
}
