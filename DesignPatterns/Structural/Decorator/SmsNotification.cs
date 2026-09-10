namespace DesignPatterns.Structural.Decorator
{
    internal class SmsNotification : BaseDecorator
    {
        public const int MAX_LENGTH = 16;

        public SmsNotification(INotification notification) : base(notification)
        {
        }

        protected override void AddBehavior(string message)
        {
            foreach (var part in SplitMessage(message))
            {
                Console.WriteLine("Sending SMS: " + part);
            }
        }

        private IEnumerable<string> SplitMessage(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                yield break;
            }
            for (int i = 0; i < message.Length; i += MAX_LENGTH)
            {
                yield return message.Substring(i, Math.Min(MAX_LENGTH, message.Length - i));
            }
        }
    }
}
