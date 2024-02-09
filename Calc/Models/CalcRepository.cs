using System.Data;
using System;
using Microsoft.AspNetCore.Http.HttpResults;
using DynamicExpresso;

namespace Calc.Models
{
    public class CalcRepository : ICalcRepository
    {
        public double CalcFromString(Values values)
        {
            var interpreter = new Interpreter();
            return Convert.ToDouble(interpreter.Eval(values.str));
        }

        public double Division(Values values)
        {
            return values.num1 / values.num2;
        }

        public double Minus(Values values)
        {
            return values.num1 - values.num2;
        }

        public double Multiplication(Values values)
        {
            return values.num1 * values.num2;
        }

        public double Plus(Values values)
        {
            return values.num1 + values.num2;
        }

        public double Pow(Values values)
        {
            return Math.Pow(values.num1, values.num2);
        }

        public double Sqrt(Values values)
        {
            return Math.Sqrt(values.num1);
        }
    }
}
