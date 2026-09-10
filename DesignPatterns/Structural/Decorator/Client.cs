namespace DesignPatterns.Structural.Decorator
{
    internal class Client
    {
        public static void Execute()
        {
            INotification notification = new SystemNotification();

            Notify(notification);
        }

        private static void Notify(INotification notification)
        {
            while (true)
            {
                var text = Console.ReadLine();

                notification.Send(text);
            }
        }
    }
}
