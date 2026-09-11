namespace DesignPatterns.Behavioral.Memento
{
    internal class Caretaker<T> : IDisposable where T : ICloneable, IRestorable<T>
    {
        private ICollection<Memento<T>> _mementos = [];

        protected T _originator;
        public Caretaker(T originator)
        {
            _originator = originator;
        }

        public void SaveState()
        {
            var memento = new Memento<T>(_originator);
            _mementos.Add(memento);
            Console.WriteLine($"Caretaker: snapshot {memento.DateTime}");
        }
        public void RestoreState(DateTime dateTime)
        {
            var memento = _mementos.LastOrDefault(x => x.DateTime <= dateTime);
            RestoreState(memento);

        }
        public void RestoreState()
        {
            var memento = _mementos.LastOrDefault();
            RestoreState(memento);
            _mementos.Remove(memento);
        }

        private void RestoreState(Memento<T>? memento)
        {
            if (memento != null)
            {
                _originator.Restore(memento);
                Console.WriteLine($"Caretaker: restored to snapshot {memento.DateTime}");
            }
            else
            {
                Console.WriteLine("Caretaker: no snapshot to restore");
            }
        }

        public virtual void Dispose()
        {
            _mementos.Clear();
            _mementos = null!;
            _originator = default!;
        }
    }
}
