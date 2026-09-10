namespace DesignPatterns.Creational.Builder
{
    internal class Client
    {
        public static void Execute()
        {
            var vehicle = new Vehicle(wheels: 4, seats: 5, doors: 4, trunkCapacity: 500, enginePower: 100);
            Console.WriteLine(vehicle);

            var builder = new VehicleBuilder();
            builder.SetWheels(4);
            builder.SetSeats(5);
            builder.SetDoors(4);
            builder.SetTrunkCapacity(500);
            builder.SetEnginePower(100);

            vehicle = builder.Build();
            Console.WriteLine(vehicle);

            builder.SetWheels(6);
            Console.WriteLine(builder.Build());
            Console.WriteLine(vehicle);

            vehicle = new VehicleBuilder()
                .SetWheels(4)
                .SetSeats(5)
                .SetDoors(4)
                .SetTrunkCapacity(500)
                .SetEnginePower(100)
                .Build();
            Console.WriteLine(vehicle);

            //alternatywnie bez buildera - initializer obiektów
            vehicle = new Vehicle { Doors = 2, Seats = 2, Wheels = 4, EnginePower = 150, TrunkCapacity = 200 };
            Console.WriteLine(vehicle);
        }
    }
}
