namespace DesignPatterns.Structural.Decorator
{
    internal abstract class BaseDecorator : INotification
    {
        protected INotification _notification;

        protected BaseDecorator(INotification notification)
        {
            _notification = notification;
        }

        public void Send(string message)
        {
            _notification.Send(message);
            AddBehavior(message);
        }

        protected abstract void AddBehavior(string message);
    }
}
