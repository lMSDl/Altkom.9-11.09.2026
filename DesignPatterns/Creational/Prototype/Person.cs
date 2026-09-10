namespace DesignPatterns.Creational.Prototype
{
    internal class Person : ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Address? Address { get; set; }
        public ICollection<Person> Children { get; private set; } = [];

        //domyślne klonowanie - płytkie klonowanie z ręcznym klonowaniem obiektów referencyjnych
        //ręczne dostosowanie głbokości klonowania - najczęściej wykorzystywane
        public object Clone()
        {
            var clonedPerson = (Person)MemberwiseClone();
            clonedPerson.Address = Address?.Clone();
            clonedPerson.Children = Children.ToList();
            return clonedPerson;
        }

        //głębokie klonowanie - kopiuje również obiekty referencyjne
        public object DeepClone()
        {
            var clonedPerson = (Person)MemberwiseClone();
            clonedPerson.Address = Address?.Clone();
            clonedPerson.Children = [.. Children.Select(child => (Person)child.Clone())];
            return clonedPerson;
        }

        //płytkie klonowanie - kopiuje tylko wartości pól, a nie obiekty referencyjne
        public object ShallowClone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            var childrenNames = string.Join(", ", Children.Select(child => $"{child.FirstName} {child.LastName}"));
            return $"Name: {FirstName} {LastName}, Age: {Age}, Address: {Address?.Street}, {Address?.City}, Children: [{childrenNames}]";
        }
    }
}
