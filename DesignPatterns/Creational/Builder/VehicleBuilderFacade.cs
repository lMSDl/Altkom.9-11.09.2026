namespace DesignPatterns.Creational.Builder
{
    public class VehicleBuilderFacade : BaseBuilder<Vehicle>
    {
        public VehicleBuilderFacade(Vehicle? vehicle = default) : base(vehicle)
        {
        }

        public VehicleBuilder Technical => new VehicleBuilder(_object);
        public VehicleProductionBuilder Production => new VehicleProductionBuilder(_object);
    }
}
