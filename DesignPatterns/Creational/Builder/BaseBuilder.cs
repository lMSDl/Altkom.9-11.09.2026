namespace DesignPatterns.Creational.Builder
{
    public abstract class BaseBuilder<T> where T : ICloneable, new()
    {
        protected readonly T _object;
        protected BaseBuilder(T? @object = default)
        {
            _object = @object ?? new T();
        }

        public T Build()
        {
            return (T)_object.Clone();
        }
    }
}
