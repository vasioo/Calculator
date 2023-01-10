using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class MathOperations
    {
        public decimal FirstValue { get; set; }
        public char Operation { get; set; }
        public decimal SecondValue { get; set; }

        public MathOperations(
            decimal firstValue,
            char operation,
            decimal secondValue)
        {
            FirstValue = firstValue;
            Operation = operation;
            SecondValue = secondValue;
        }

        internal decimal Add(decimal first, decimal second)
        {
            return first + second;
        }
        internal decimal Substract(decimal first, decimal second)
        {
            return first - second;
        }
        internal decimal Multiply(decimal first, decimal second)
        {
            return first * second;
        }
        internal decimal Devide(decimal first, decimal second)
        {
            return Math.Round(first / second, 5);
        }
        internal decimal Percent(decimal element)
        {
            return element / 100;
        }
    }
}
