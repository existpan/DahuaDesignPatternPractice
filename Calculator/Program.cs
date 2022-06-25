using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入A：");
            string parameterA = Console.ReadLine();
            Console.WriteLine("请输入运算符:");
            string operation = Console.ReadLine();
            Console.WriteLine("请输入B：");
            string parameterB = Console.ReadLine();
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = Convert.ToDouble(parameterA) + Convert.ToDouble(parameterB);
                    break;
                case "-":
                    result = Convert.ToDouble(parameterA) - Convert.ToDouble(parameterB);
                    break;
                case "*":
                    result = Convert.ToDouble(parameterA) * Convert.ToDouble(parameterB);
                    break;
                case "/":
                    if (parameterB != "0")
                    {
                        result = Convert.ToDouble(parameterA) / Convert.ToDouble(parameterB);
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine(result.ToString());
        }
    }
}
