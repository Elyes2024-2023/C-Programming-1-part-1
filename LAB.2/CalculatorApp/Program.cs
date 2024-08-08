using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation calc = new Calculation();

            double a = 10;
            double b = 5;

            Console.WriteLine($"{a} + {b} = {calc.Add(a, b)}");
            Console.WriteLine($"{a} - {b} = {calc.Subtract(a, b)}");
            Console.WriteLine($"{a} * {b} = {calc.Multiply(a, b)}");
            Console.WriteLine($"{a} / {b} = {calc.Divide(a, b)}");

            b = 0;
            try
            {
                Console.WriteLine($"{a} / {b} = {calc.Divide(a, b)}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
