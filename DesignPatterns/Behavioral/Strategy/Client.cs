namespace DesignPatterns.Behavioral.Strategy
{
    internal class Client
    {
        public static void Execute()
        {
            var calculator = new Calculator();
            while (true)
            {
                var line = Console.ReadLine();
                var split = line.Split(' '); // 2 + 4
                if (split.Length < 3)
                    continue;

                calculator.Strategy = GetStrategy(split[1]);

                if (calculator.Strategy == null)
                {
                    Console.WriteLine("Invalid operator");
                    continue;
                }

                if (float.TryParse(split[0], out var a) && float.TryParse(split[2], out var b))
                {
                    var result = calculator.Operate(a, b);
                    Console.WriteLine(result);
                    Console.WriteLine(GetFunc(split[1])?.Invoke(a, b));

                }
                else
                {
                    Console.WriteLine("Invalid numbers");
                }
            }
        }

        private static ICalcStrategy? GetStrategy(string v)
        {
            return v switch
            {
                "+" => new AddStrategy(),
                "-" => new SubtractStrategy(),
                "*" => new MultiplyStrategy(),
                "/" => new DivideStrategy(),
                _ => null
            };
        }

        private static Func<float, float, float>? GetFunc(string v)
        {
            return v switch
            {
                "+" => (a, b) => a + b,
                "-" => (a, b) => a - b,
                "*" => (a, b) => a * b,
                "/" => (a, b) => a / b,
                _ => null
            };
        }
    }
}
