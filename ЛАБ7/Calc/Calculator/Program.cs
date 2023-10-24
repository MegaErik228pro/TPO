using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Subtract(double a, double b)
        {
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new Exception("Деление на ноль");
            }
            return a / b;
        }
        public double SquareRoot(double d)
        {
            return Math.Sqrt(d);
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите 1 число ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Введите действие (+, -, *, /, s(Корен)) ");
                char operation = Console.ReadKey().KeyChar;
                Console.WriteLine();

                double b = 0;
                if (operation != 's')
                {
                    Console.Write("Введите 2 число ");
                    b = double.Parse(Console.ReadLine());
                }

                var calc = new Calculator();

                switch (operation)
                {
                    case '+':
                        Console.WriteLine("{0}+{1}={2}", a, b, calc.Add(a, b));
                        break;
                    case '-':
                        Console.WriteLine("{0}-{1}={2}", a, b, calc.Subtract(a, b));
                        break;
                    case '*':
                        Console.WriteLine("{0}*{1}={2}", a, b, calc.Multiply(a, b));
                        break;
                    case '/':
                        Console.WriteLine("{0}/{1}={2}", a, b, calc.Divide(a, b));
                        break;
                    case 's':
                        Console.WriteLine("Корень ({0})={1}", a, calc.SquareRoot(a));
                        break;
                    default:
                        Console.WriteLine("Ошибка ввода");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
