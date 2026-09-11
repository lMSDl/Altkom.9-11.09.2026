using System.ComponentModel;

namespace DesignPatterns.Behavioral.Memento
{
    internal class AutoCaretaker<T> : Caretaker<T> where T : ICloneable, IRestorable<T>, INotifyPropertyChanging
    {
        public AutoCaretaker(T originator) : base(originator)
        {
            originator.PropertyChanging += Originator_PropertyChanging;
        }

        private void Originator_PropertyChanging(object? sender, PropertyChangingEventArgs e)
        {
            SaveState();
        }

        override public void Dispose()
        {
            _originator.PropertyChanging -= Originator_PropertyChanging;
            base.Dispose();
        }
    }
}
