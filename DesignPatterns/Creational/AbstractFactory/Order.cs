namespace DesignPatterns.Creational.AbstractFactory
{
    internal class Order
    {
        private ICar? car;
        public string? CarName()
        {
            return car?.Name;
        }

        public void OrderSuv(ISuvFactory factory, string segment)
        {
            car = factory.CreateSuv(segment);
        }

        public void OrderSedan(ISedanFactory factory, string segment)
        {
            car = factory.CreateSedan(segment);
        }
    }
}
