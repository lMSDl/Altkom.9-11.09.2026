namespace DesignPatterns.Structural.Flyweight
{
    internal class ProductFlyweight : ICloneable
    {
        public string Manufacturer { get; set; }
        public byte[] Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Weight { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void ShowShortInfo(Product context)
        {
            Console.WriteLine($"Manufacturer: {Manufacturer}, Name: {Name}, Weight: {Weight}kg, Expiry Date: {context.ExpiryDate.ToShortDateString()}, Description: {Description}");
        }
    }
}
