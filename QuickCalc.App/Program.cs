using System;
using QuickCalc.Core;

namespace QuickCalc.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // optional: keep empty
        }
    }

    // IMPORTANT: Program class'ının DIŞINDA
    public static class QuickCalcEvaluator
    {
        public static string Evaluate(string input)
        {
            if (input == null) return "ERR";

            string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length != 3) return "ERR";

            if (!double.TryParse(parts[0], out double a)) return "ERR";
            if (!double.TryParse(parts[2], out double b)) return "ERR";

            string op = parts[1];

            try
            {
                if (op == "+") return Calculator.Add(a, b).ToString();
                if (op == "-") return Calculator.Subtract(a, b).ToString();
                if (op == "*") return Calculator.Multiply(a, b).ToString();
                if (op == "/") return Calculator.Divide(a, b).ToString();
                return "ERR";
            }
            catch (DivideByZeroException)
            {
                return "ERR";
            }
        }
    }
}