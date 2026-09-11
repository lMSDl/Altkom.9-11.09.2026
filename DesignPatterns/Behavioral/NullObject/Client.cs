using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.NullObject
{
    internal class Client
    {
        public static void Execute()
        {
            var objects = new AbstractObject[] { new RealObject(), null };

            while (true)
            {
                var value = Random.Shared.Next(0, objects.Length);

                Console.ReadLine();
                var item = objects[value];

                item.Method1();
                item.Method2();
                item.Method3();

            }
        }
    }
}
