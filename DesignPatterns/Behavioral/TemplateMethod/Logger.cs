namespace DesignPatterns.Behavioral.TemplateMethod
{
    internal abstract class Logger<T, TService> where TService : IDisposable
    {
        public void Log(object message)
        {
            var preparedMessage = PrepareMessage(message);
            TService? service = GetService();
            T item = CreateItem(preparedMessage);
            WriteLogMessage(service, item);
            CloseService(service);
        }

        protected virtual void CloseService(TService? service)
        {
            service?.Dispose();
        }

        protected abstract void WriteLogMessage(TService service, T? item);
        protected abstract T CreateItem(string preparedMessage);
        protected abstract TService? GetService();

        protected virtual string PrepareMessage(object message)
        {
            Console.WriteLine("Serializing message");
            return $"{DateTime.Now}: {message}";
        }
    }
}
