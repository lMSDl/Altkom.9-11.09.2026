using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy
{
    internal class MultiplyStrategy : ICalcStrategy
    {
        public float Calc(float a, float b)
        {
            return a * b;
        }
    }
}