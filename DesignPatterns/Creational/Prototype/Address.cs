namespace DesignPatterns.Creational.Prototype
{
    internal class Address : ICloneable<Address>
    {
        public string City { get; set; }
        public string Street { get; set; }

        public Address Clone()
        {
            return (Address)MemberwiseClone();
        }
    }
}
