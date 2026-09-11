namespace DesignPatterns.Behavioral.Memento
{
    internal interface IRestorable<T> where T : ICloneable
    {
        void Restore(Memento<T> memento);
    }
}
