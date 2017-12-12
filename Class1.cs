using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorDemo
{
    public class Calculator
    {
        /// <summary>
        /// Calculate sum
        /// </summary>
        /// <param name="expression">Digits to add as string</param>
        /// <returns>Sum</returns>
        public int Add(string expression)
        {
            if (string.IsNullOrEmpty(expression)
            {
                return 0;
            }
            int sum = int.Parse(expression);
            return sum;


        }
    }
}
