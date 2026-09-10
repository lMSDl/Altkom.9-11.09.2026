namespace DesignPatterns.Creational.Prototype
{
    internal class Client
    {
        public static void Execute()
        {
            var p0 = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 30,
                Address = new Address { City = "New York", Street = "5th Avenue" }
            };
            p0.Children.Add(new Person { FirstName = "Junior", LastName = "Doe", Age = 5 });
            p0.Children.Add(new Person { FirstName = "Baby", LastName = "Doe", Age = 2 });

            var p1 = (Person)p0.Clone();
            p1.FirstName = "Jane";

            Console.WriteLine(p0);
            Console.WriteLine(p1);

            p0.Address.Street = "Madison Avenue";
            p1.Children.First().FirstName = "Little";
            p1.Children.Add(new Person { FirstName = "Newborn", LastName = "Doe", Age = 0 });

            Console.WriteLine(p0);
            Console.WriteLine(p1);
        }
    }
}
