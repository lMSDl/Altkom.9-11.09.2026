namespace DesignPatterns.Structural.Flyweight
{
    internal class Client
    {
        public static void Execute()
        {
            Console.WriteLine(FlyweightFactory.Instance);

            var product1 = new Product
            {
                Manufacturer = "Company A",
                Logo = new byte[] { 0x01, 0x02, 0x03 },
                Name = "Product 1",
                Description = "Description of Product 1",
                Weight = 1.5f,
                ProductionDate = DateTime.Now,
                ExpiryDate = DateTime.Now.AddYears(1)
            };

            //product1.Flyweight = FlyweightFactory.Instance.GetFlyweight(product1.Flyweight);
            Console.WriteLine(FlyweightFactory.Instance);

            var product11 = new Product
            {
                Manufacturer = "Company A",
                Logo = new byte[] { 0x01, 0x02, 0x03 },
                Name = "Product 1",
                Description = "Description of Product 1",
                Weight = 1.5f,
                ProductionDate = DateTime.Now.AddDays(-12),
                ExpiryDate = DateTime.Now.AddYears(1).AddDays(-44)
            };
            //product11.Flyweight = FlyweightFactory.Instance.GetFlyweight(product11.Flyweight);
            Console.WriteLine(FlyweightFactory.Instance);


            var product2 = new Product
            {
                Manufacturer = "Company B",
                Logo = new byte[] { 0x04, 0x05, 0x06 },
                Name = "Product 2",
                Description = "Description of Product 2",
                Weight = 2.0f,
                ProductionDate = DateTime.Now.AddDays(-30),
                ExpiryDate = DateTime.Now.AddYears(1).AddDays(-30)
            };

            //product2.Flyweight = FlyweightFactory.Instance.GetFlyweight(product2.Flyweight);
            Console.WriteLine(FlyweightFactory.Instance);

            var product21 = new Product
            {
                Manufacturer = "Company B",
                Logo = new byte[] { 0x04, 0x05, 0x06 },
                Name = "Product 2",
                Description = "Description of Product 2",
                Weight = 2.0f,
                ProductionDate = DateTime.Now.AddDays(-60),
                ExpiryDate = DateTime.Now.AddYears(1).AddDays(-60)
            };
            product21.Flyweight = FlyweightFactory.Instance.GetFlyweight(product21.Flyweight);
            Console.WriteLine(FlyweightFactory.Instance);


            product2.Description = "Updated Description of Product 2";
            //var flyweight = (ProductFlyweight)product2.Flyweight.Clone();
            //flyweight.Description = "Updated Description of Product 2";
            //product2.Flyweight = FlyweightFactory.Instance.GetFlyweight(flyweight);

            product1.ShowShortInfo();
            product11.ShowShortInfo();
            product2.ShowShortInfo();
            product21.ShowShortInfo();
        }
    }
}
