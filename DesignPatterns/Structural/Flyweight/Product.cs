namespace DesignPatterns.Structural.Flyweight
{
    internal class Product
    {
        /*public string Manufacturer { get => Flyweight.Manufacturer; set => Flyweight.Manufacturer = value; }
        public byte[] Logo { get => Flyweight.Logo; set => Flyweight.Logo = value; }
        public string Name { get => Flyweight.Name; set => Flyweight.Name = value; }
        public string Description { get => Flyweight.Description; set => Flyweight.Description = value; }
        public float Weight { get => Flyweight.Weight; set => Flyweight.Weight = value; }*/
        public string Manufacturer { get => Flyweight.Manufacturer; set => SetValue(f => f.Manufacturer = value); }
        public byte[] Logo { get => Flyweight.Logo; set => SetValue(f => f.Logo = value); }
        public string Name { get => Flyweight.Name; set => SetValue(f => f.Name = value); }
        public string Description { get => Flyweight.Description; set => SetValue(f => f.Description = value); }
        public float Weight { get => Flyweight.Weight; set => SetValue(f => f.Weight = value); }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpiryDate { get; set; }

        public ProductFlyweight Flyweight { get; set; } = new();

        private void SetValue(Action<ProductFlyweight> action)
        {
            var clone = (ProductFlyweight)Flyweight.Clone();
            action(clone);
            Flyweight = FlyweightFactory.Instance.GetFlyweight(clone);  
        }

        public void ShowShortInfo()
        {
            Flyweight.ShowShortInfo(this);
        }
    }
}
