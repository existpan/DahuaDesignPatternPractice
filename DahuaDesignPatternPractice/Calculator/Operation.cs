using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// 运算类
    /// </summary>
    public class Operation
    {
        public static double GetOperationResult(double parameterA, double parameterB, string operation)
        {
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = parameterA + parameterB;
                    break;
                case "-":
                    result = parameterA + parameterB;
                    break;
                case "*":
                    result = parameterA + parameterB;
                    break;
                case "/":
                    if (parameterB != 0)
                    {
                        result = parameterA / parameterB;
                    }
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
