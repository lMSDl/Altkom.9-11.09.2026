namespace DesignPatterns.Creational.FactoryMethod
{
    internal class Client
    {
        public static void Execute()
        {
            //var elevator = new Elevator();
            var elevator = new HorizontalElevator();
            
            var request = new Request("UP", 5);
            elevator.Execute(request.Operation, request.Floor);


            request = new Request("GOTO", 8);
            elevator.Execute(request.Operation, request.Floor);

            request = new Request("LEFT", 3);
            elevator.Execute(request.Operation, request.Floor);

            request = new Request("RIGHT", 7);
            elevator.Execute(request.Operation, request.Floor);

            /*IElevatorOperation? operation = request.Operation switch
            {
                "UP" => new ElevatorUp(),
                "DOWN" => new ElevatorDown(),
                _ => null
            };
            if (operation is not null)
            {
                elevator.Execute(operation, request.Floor);
            }
            else
            {
                Console.WriteLine("Invalid operation");
            }*/
        }

        class HorizontalElevator : Elevator
        {
            protected override IElevatorOperation? CreateOperation(string operation)
            {
                return operation switch
                {
                    "LEFT" => new ElevatorLeft(),
                    "RIGHT" => new ElevatorRight(),
                    _ => base.CreateOperation(operation)
                };
            }
        }

        record Request(string Operation, int Floor);
    }
}
