using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    internal class ElevatorRight : IElevatorOperation
    {
        public void Operate(int floor)
        {
            Console.WriteLine($"Elevator will move to the RIGHT {floor} station");
        }
    }
}
