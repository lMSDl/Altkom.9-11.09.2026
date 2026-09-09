namespace DesignPatterns.Creational.FactoryMethod
{
    internal class Elevator
    {
        public void Execute(IElevatorOperation operation, int floor)
        {
            operation.Operate(floor);
        }


        public void Execute(string operation, int floor)
        {
            var operationInstance = CreateOperation(operation);
            if (operationInstance != null)
            {
                Execute(operationInstance, floor);
            }
            else
            {
                throw new ArgumentException($"Invalid operation: {operationInstance}");
            }
        }

        private Dictionary<string, IElevatorOperation> _operations = [];
        protected virtual IElevatorOperation? CreateOperation(string operation)
        {
            //wzorzec nie musi tworzyć zawsze nowego obiektu, może zwracać istniejący obiekt z cache
            if (_operations.ContainsKey(operation))
            {
                return _operations[operation];
            }

            IElevatorOperation? result = operation switch
            {
                "UP" => new ElevatorUp(),
                "DOWN" => new ElevatorDown(),
                "GOTO" => new ElevatorGoTo(),
                _ => null,
            };

            if (result != null)
            {
                _operations[operation] = result;
            }
            return result;
        }
    }
}
