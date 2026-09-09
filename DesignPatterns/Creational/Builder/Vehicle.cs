namespace DesignPatterns.Creational.Builder
{
    internal class Vehicle
    {
        //builder jako klasa wewnętrzna, która ma dostęp do prywatnego konstruktora Vehicle i może tworzyć obiekty Vehicle z różnymi konfiguracjami.
        //jest to sposób na zablokowanie możliwości tworzenia obiektów Vehicle bezpośrednio, a jednocześnie umożliwienie tworzenia ich za pomocą Buildera.
        /*private Vehicle()
        {

        }
        public class Builder
        {
            private Vehicle _vehicle = new Vehicle();



            public Vehicle Build()
            {
                return _vehicle;
            }
        }*/
        internal Vehicle()
        {

        }

        public Vehicle(int wheels, int seats)
        {
            Wheels = wheels;
            Seats = seats;
        }

        public Vehicle(int wheels, int seats, int? trunkCapacity) : this(wheels, seats)
        {
            TrunkCapacity = trunkCapacity;
        }

        public Vehicle(int wheels, int? enginePower, int seats) : this(wheels, seats)
        {
            EnginePower = enginePower;
        }

        public Vehicle(int wheels, int seats, int doors, int? trunkCapacity, int? enginePower) : this(wheels, seats)
        {
            Doors = doors;
            TrunkCapacity = trunkCapacity;
            EnginePower = enginePower;
        }


        public int Wheels { get; set; }
        public int Seats { get; set; }
        public int Doors { get; set; }
        public int? TrunkCapacity { get; set; }
        public int? EnginePower { get; set; }

        public override string ToString()
        {
            return $"Wheels: {Wheels}, Seats: {Seats}, Doors: {Doors}, TrunkCapacity: {TrunkCapacity}, EnginePower: {EnginePower}";
        }
    }
}
