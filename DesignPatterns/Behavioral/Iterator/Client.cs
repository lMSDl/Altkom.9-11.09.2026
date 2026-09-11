using System.Reactive.Linq;

namespace DesignPatterns.Behavioral.Iterator
{
    internal class Client
    {
        public static void Execute()
        {
            //ICollection
            IEnumerable<string> collection = new List<string>() { "1", "2", "3", "4", "5", "6" };

            //IIterator
            IEnumerator<string> iterator = collection.GetEnumerator();
            if(iterator.MoveNext())
            {
                string item = iterator.Current;
                while (iterator.MoveNext())
                {
                    Console.WriteLine(item + iterator.Current);
                    item = iterator.Current;
                }
            }

            Console.WriteLine("--");

            var bufferIterator = new BufferIterator<string>(collection.GetEnumerator());
            while (bufferIterator.MoveNext())
            {
                /*var (current, next) = bufferIterator.Current;
                Console.WriteLine(current + next);*/
                Console.WriteLine(bufferIterator.Current.Item1 + bufferIterator.Current.Item2);
            }

            Console.WriteLine("--");

            var buffer = new Buffer<string>(collection);
            foreach (var (current, next) in buffer)
            {
                Console.WriteLine(current + next);
            }

            Console.WriteLine("--");

            collection.ToObservable()
                .Buffer(2, 1)
                .Where(x => x.Count == 2)
                .Subscribe(x => Console.WriteLine(x[0] + x[1]));

        }
    }
}
