namespace DesignPatterns.Behavioral.Observer
{
    internal class Client
    {
        public static void Execute()
        {
            SubscriberA sub1 = new();
            SubscriberB sub2 = new();

            Publisher publisher = new();

            sub1.Subscription = publisher.Subscribe(sub1);
            sub2.Subscription = publisher.Subscribe(sub2);

            _ = Task.Delay(7000).ContinueWith(x => sub2.Subscription.Dispose());
            _ = Task.Delay(12000).ContinueWith(x => sub2.Subscription = publisher.Subscribe(sub2));


            publisher.Work().Wait();
        }
    }
}
