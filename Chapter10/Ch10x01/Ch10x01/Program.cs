using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10x01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating object myobj...");
            MyClass myobj = new MyClass("My Object");
            Console.WriteLine("My obj created");
            for (int i = -1; i < 0; i++)
            {
                try
                {
                    Console.WriteLine("\nAttempting to assign {0} to myObj.val ...", i);
                    myobj.Val = i;
                    Console.WriteLine("Value {0} assingned to myObj.Val.", myobj.Val);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception {0} thrown", e.GetType().FullName);
                    Console.WriteLine("Message: \n\"{0}\"",e.Message);
                }
            }
            Console.WriteLine("\nOutputting myObj.ToString()...");
            Console.WriteLine(myobj.ToString());
            Console.WriteLine("myObj.ToString() Output. ");
            Console.ReadKey();
        }
    }
}
