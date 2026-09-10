namespace DesignPatterns.Structural.Composite
{
    internal class Container : IComponent
    {
        private List<IComponent> _components = new List<IComponent>();
        public string Name => GetType().Name;
        public void Add(IComponent component)
        {
            _components.Add(component);
        }
        public void Remove(IComponent component)
        {
            _components.Remove(component);
        }
        public IComponent GetComponent(int index)
        {
            return _components[index];
        }
        public float GetValue()
        {
            float totalValue = 0;
            Console.WriteLine("Calculating total value of {0}:", Name);
            foreach (var component in _components)
            {
                totalValue += component.GetValue();
            }
            Console.WriteLine("Total value of {0} is {1}", Name, totalValue);
            return totalValue;
        }
    }
}
