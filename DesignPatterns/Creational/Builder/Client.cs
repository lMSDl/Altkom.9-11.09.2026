namespace DesignPatterns.Creational.Builder
{
    internal class Client
    {
        public static void Execute()
        {
            var vehicle = new Vehicle(wheels: 4, seats: 5, doors: 4, trunkCapacity: 500, enginePower: 100);

            Console.WriteLine(vehicle);
        }
    }
}
