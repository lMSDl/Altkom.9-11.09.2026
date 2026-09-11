namespace DesignPatterns.Behavioral.Strategy
{
    internal class DivideStrategy : ICalcStrategy
    {
        public float Calc(float a, float b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }
    }
}
