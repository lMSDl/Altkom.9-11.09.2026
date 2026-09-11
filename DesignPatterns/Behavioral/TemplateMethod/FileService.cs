namespace DesignPatterns.Behavioral.TemplateMethod
{
    internal class FileService : IDisposable
    {
        internal void Write(string message)
        {
            Console.WriteLine("Appending Log message to file : " + message);
        }

        public void Dispose()
        {
            Console.WriteLine("Closing File.");
        }
    }
}