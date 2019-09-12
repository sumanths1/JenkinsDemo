using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
  public static  class Operations
    {
        static  double num1 = 0;
        static  double num2 = 0;
        static  double Result = 0;
        public static double ADD(double num1, double num2)
        {
            return (num1 + num2);
          
        }

        public static double SUB(double num1, double num2)
        {
          
            return (num1 - num2);
            
        }

        public static double MUL(double num1, double num2)
        {
          
            return (num1 * num2);
            
        }

        public static double DIV(double num1, double num2)
        {
           
          return (num1/num2);
          
        }
    }
}
