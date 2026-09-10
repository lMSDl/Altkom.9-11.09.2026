using System.Text;

namespace DesignPatterns.Structural.Flyweight
{
    internal class FlyweightFactory
    {
        static FlyweightFactory()
        {

        }
        public static FlyweightFactory Instance { get; } = new FlyweightFactory();

        public void Initialize(params ProductFlyweight[] initialFlyweights)
        {
            foreach (var flyweight in initialFlyweights)
            {
                var key = GetKey(flyweight);
                if (!_flyweights.ContainsKey(key))
                {
                    _flyweights[key] = flyweight;
                }
            }
        }

        private string GetKey(ProductFlyweight flyweight)
        {
            return string.Join("|", typeof(ProductFlyweight).GetProperties().Where(x => x.CanRead && x.CanWrite).OrderBy(x => x.Name).Select(x => x.GetValue(flyweight)));
        }

        Dictionary<string, ProductFlyweight> _flyweights = [];
        public ProductFlyweight GetFlyweight(ProductFlyweight productFlyweight)
        {
            var key = GetKey(productFlyweight);

            if (_flyweights.TryGetValue(key, out var flyweight))
            {
                Console.WriteLine("FlyweightFactory: Reusing existing flyweight.");
                return flyweight;
            }
            else
            {
                Console.WriteLine("FlyweightFactory: Creating new flyweight.");
                _flyweights[key] = productFlyweight;
                return productFlyweight;
            }
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"FlyweightFactory count: {_flyweights.Count}");
            foreach (var flyweight in _flyweights)
            {
                stringBuilder.AppendLine(flyweight.Key);
            }
            return stringBuilder.ToString();
        }
    }
}
