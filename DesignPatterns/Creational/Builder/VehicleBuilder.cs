namespace DesignPatterns.Creational.Builder
{
    public class VehicleBuilder : VehicleBuilderFacade
    {

        public VehicleBuilder(Vehicle? vehicle = default) : base(vehicle)
        {
        }

        public VehicleBuilder SetWheels(int wheels)
        {
            _object.Wheels = wheels;
            return this;
        }

        public VehicleBuilder SetSeats(int seats)
        {
            _object.Seats = seats;
            return this;
        }

        public VehicleBuilder SetDoors(int doors)
        {
            _object.Doors = doors;
            return this;
        }

        public VehicleBuilder SetTrunkCapacity(int trunkCapacity)
        {
            _object.TrunkCapacity = trunkCapacity;
            return this;
        }

        public VehicleBuilder SetEnginePower(int enginePower)
        {
            _object.EnginePower = enginePower;
            return this;
        }
    }
}
