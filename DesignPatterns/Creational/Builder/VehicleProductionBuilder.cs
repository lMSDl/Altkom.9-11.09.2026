namespace DesignPatterns.Creational.Builder
{
    public class VehicleProductionBuilder : VehicleBuilderFacade
    {

        public VehicleProductionBuilder(Vehicle? vehicle = default) : base(vehicle)
        {
        }

        public VehicleProductionBuilder SetManufacturer(string manufacturer)
        {
            _object.Manufacturer = manufacturer;
            return this;
        }

        public VehicleProductionBuilder SetModel(string model)
        {
            _object.Model = model;
            return this;
        }

        public VehicleProductionBuilder SetYear(int year)
        {
            _object.Year = year;
            return this;
        }

        public VehicleProductionBuilder SetColor(string color)
        {
            _object.Color = color;
            return this;
        }
    }
}
