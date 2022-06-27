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
            try
            {
                Console.WriteLine("请输入数字A：");
                string parameterA = Console.ReadLine();
                Console.WriteLine("请输入运算符+、-、*、/:");
                string operation = Console.ReadLine();
                Console.WriteLine("请输入数字B：");
                string parameterB = Console.ReadLine();
                double result = Operation.GetOperationResult(Convert.ToDouble(parameterA), Convert.ToDouble(parameterB), operation);
                Console.WriteLine("\n结果是:"+result);
            }
            catch (Exception ex)
            {
                throw new Exception( ex.Message);
            }
            Console.ReadKey();
        }
    }
}
