namespace DesignPatterns.Structural.Composite
{
    internal class Client
    {
        public static void Execute()
        {
            var warehouse = new Warehouse();

            var shelf1 = new Shelf();
            var shelf2 = new Shelf();

            var box1 = new Box();
            var box2 = new Box();
            var box3 = new Box();
            var box4 = new Box();

            warehouse.Add(shelf1);
            warehouse.Add(shelf2);

            shelf1.Add(box1);
            shelf1.Add(box2);

            shelf2.Add(box3);

            warehouse.Add(box4);

            for (int i = 0; i < 10; i++)
            {
                box1.Add(new Soda(3));
                box2.Add(new Toy(5));
                box3.Add(new Tea(2));
            }

            for (int i = 0; i < 5; i++)
            {
                box4.Add(new Soda(5));
                box4.Add(new Tea(3));
            }

            shelf1.Add(new Toy(15));

            Console.WriteLine("Total value of warehouse: {0}", warehouse.GetValue());
            Console.WriteLine("----");
            Console.WriteLine("Total value of shelf1: {0}", shelf1.GetValue());
            Console.WriteLine("----");
            Console.WriteLine("Total value of ???: {0}", warehouse.GetComponent(2).GetValue());
        }
    }
}
