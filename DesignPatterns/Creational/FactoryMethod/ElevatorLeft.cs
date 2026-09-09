namespace DesignPatterns.Creational.FactoryMethod
{
    internal class ElevatorLeft : IElevatorOperation
    {
        public void Operate(int floor)
        {
            Console.WriteLine($"Elevator will move to the LEFT {floor} station");
        }
    }
}
