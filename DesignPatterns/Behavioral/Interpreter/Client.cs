namespace DesignPatterns.Behavioral.Interpreter
{
    internal class Client
    {
        public static void Execute()
        {
            // Example expression: |(5 + 3) - 10|
            var result = new AbsExpression(
                new MinusExpression(
                    new PlusExpression(
                        new NumberExpression("5"), new NumberExpression("3")),
                    new NumberExpression("10")
                    )
                ).Interpret();


            Console.WriteLine(result);
        }
    }
}
