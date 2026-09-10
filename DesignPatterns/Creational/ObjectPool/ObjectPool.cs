using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.ObjectPool
{
    internal class ObjectPool<T>
    {
        private ConcurrentQueue<T> _queue;
        public ObjectPool(Func<T> objectGenerator, int initialSize)
        {
            _queue = new ConcurrentQueue<T>();
            for (int i = 0; i < initialSize; i++)
            {
                _queue.Enqueue(objectGenerator());
            }
        }



        public T? Acquire()
        {
            if (_queue.TryDequeue(out T? item))
            {
                return item;
            }
            else
            {
                return default(T);
            }

        }

        public void Release(T item)
        {
            _queue.Enqueue(item);
        }
    }
}
