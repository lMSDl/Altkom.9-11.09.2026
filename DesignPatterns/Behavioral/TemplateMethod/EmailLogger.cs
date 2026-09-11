namespace DesignPatterns.Behavioral.TemplateMethod
{
    internal class EmailLogger : Logger<Email, IDisposable>
    {
        protected override void WriteLogMessage(IDisposable service, Email? item)
        {
            Console.WriteLine("Sending Email with Log Message : " + item.Content);
        }

        protected override Email CreateItem(string preparedMessage)
        {
            Console.WriteLine("Serializing message");
            return new Email { Content = preparedMessage };
        }

        protected override IDisposable? GetService()
        {
            return null;
        }
        //implementacja kroków metody szablonowej często prowadzi do łamania zasady liskov, ponieważ niektóre klasy pochodne mogą nie potrzebować wszystkich kroków metody szablonowej.
        /*protected override void CloseService(IDisposable? service)
        {
            
        }*/
    }
}
