using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06x05
{
    class Program
    {
        delegate double ProccessDelegate(double param1,double param2);

        static double Multiply(double param1, double param2)
        {
            return param1 * param2;
        }

        static double Divide(double param1, double param2)
        {
            return param1 / param2;
        }
            
        
        static void Main(string[] arg)
        {
            ProccessDelegate proccess;
            Console.WriteLine("Enter 2 numbers seperated with a coma");
            string input = Console.ReadLine();
            int commapos = input.IndexOf(',');
            double param1 = Convert.ToDouble(input.Substring(0, commapos));
            double param2 = Convert.ToDouble(input.Substring(commapos + 1, input.Length - commapos - 1));
            Console.WriteLine("Enter M to multiply or D to divide");
            input = Console.ReadLine();
            if (input == "M")
            {
                proccess = new ProccessDelegate(Multiply);
            }
            else
            {
                proccess = new ProccessDelegate(Divide);
            }
            Console.WriteLine("Result: {0}",proccess(param1,param2));
            Console.ReadKey();
        }
    }
}
