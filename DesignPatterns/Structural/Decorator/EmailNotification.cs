namespace DesignPatterns.Structural.Decorator
{
    internal class EmailNotification : BaseDecorator
    {
        public EmailNotification(INotification notification) : base(notification)
        {
        }

        protected override void AddBehavior(string message)
        {
            Console.WriteLine("Sending Email: " + message);
        }
    }
}
