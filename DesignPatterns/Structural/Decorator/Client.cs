namespace DesignPatterns.Structural.Decorator
{
    internal class Client
    {
        public static void Execute()
        {
            while (true)
            {
                var text = Console.ReadLine();

                INotification notification = new SystemNotification();

                if (DateTime.Now.Second % 2 == 0)
                    notification = new SmsNotification(notification);
                if (DateTime.Now.Second % 3 == 0)
                    notification = new EmailNotification(notification);

                notification.Send(text);
            }
        }
    }
}
