namespace DesignPatterns.Behavioral.TemplateMethod
{
    internal class DatabaseLogger : Logger<DbLog, DatabaseService>
    {
        protected override void WriteLogMessage(DatabaseService service, DbLog? item)
        {
            service.Insert(item);
        }

        protected override string PrepareMessage(object message)
        {
            return message.ToString();
        }

        protected override DbLog CreateItem(string preparedMessage)
        {
            Console.WriteLine("Serializing message");
            return new DbLog { DateTime = DateTime.Now, Message = preparedMessage };
        }

        protected override DatabaseService GetService()
        {
            Console.WriteLine("Connecting to Database.");
            return new DatabaseService();
        }
    }
}
