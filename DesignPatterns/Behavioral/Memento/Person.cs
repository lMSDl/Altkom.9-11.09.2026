using System.ComponentModel;

namespace DesignPatterns.Behavioral.Memento
{
    internal class Person : ICloneable, IRestorable<Person>, INotifyPropertyChanging
    {
        private string firstName = string.Empty;
        private string lastName = string.Empty;

        public string FirstName
        {
            get => firstName;
            set
            {
                if (firstName != value)
                    PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(nameof(FirstName)));
                firstName = value;
            }
        }
        public string LastName
        {
            get => lastName;
            set
            {
                if (lastName != value)
                    PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(nameof(LastName)));
                lastName = value;
            }
        }

        public event PropertyChangingEventHandler? PropertyChanging;

        public object Clone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public void Restore(Memento<Person> memento)
        {
            var state = memento.GetState();
            FirstName = state.FirstName;
            LastName = state.LastName;
        }
    }
}
