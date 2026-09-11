using System.Collections;

namespace DesignPatterns.Behavioral.Iterator
{
    internal class Buffer<T> : IEnumerable<(T?, T?)>
    {
        private readonly IEnumerable<T> _collection;
        public Buffer(IEnumerable<T> collection)
        {
            _collection = collection;
        }

        public IEnumerator<(T?, T?)> GetEnumerator()
        {
            return new BufferIterator<T>(_collection.GetEnumerator());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
