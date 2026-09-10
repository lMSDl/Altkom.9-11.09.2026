namespace DesignPatterns.Creational.Singleton
{
    internal class Client
    {
        public static void Execute()
        {
            Task.Run(() =>
            {
                var context = Context.Instance;
                Console.WriteLine(context.GetSettings("1"));
            });

            Task.Run(() =>
            {
                var context = Context.Instance;
                Console.WriteLine(context.GetSettings("2"));
                context.SetSettings("3", "x");
            });

            Task.Run(() =>
            {
                var context = Context.Instance;
                Console.WriteLine(context.GetSettings("3"));
            });

            Console.ReadLine();
        }
    }
}
