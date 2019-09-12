using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Choose Math Operations Option");
            Console.WriteLine($"1:Addition","\n", "2:Addition","\n", "3:Addition","\n", "4:Addition");
            int Opt =    Int32.Parse(Console.ReadLine());

            ExecuteInputOperation(Opt);
            Console.ReadLine();

        }

        private static void ExecuteInputOperation(int opt)
        {
           

            switch (opt)
            {
                   
                case 1:
                    double RADD = 0;
                    RADD = Operations.ADD(2,3);
                    Console.WriteLine($"Äddition of two number{RADD}");
                    break;
                case 2:
                    double RSUB = 0;
                    RSUB = Operations.SUB(10, 5);
                    Console.WriteLine($"Äddition of two number{RSUB}");
                  break;
                case 3:
                    double RMUL = 0;
                    RMUL = Operations.MUL(10, 5);
                    Console.WriteLine($"Äddition of two number{RMUL}");
                    break;
                case 4:
                    double RDIV = 0;
                    RDIV = Operations.MUL(10, 5);
                    Console.WriteLine($"Äddition of two number{RDIV}");
                    break;

                default:
                    Console.Write("Enter a valid Option");
                    break;
            }
        }
    }
}
