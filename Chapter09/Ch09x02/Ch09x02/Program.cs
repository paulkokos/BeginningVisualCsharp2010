using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch09ClassLib;
//dll class
namespace Ch09x02
{
    class Program
    {
        static void Main(string[] args)
        {
            MyExternalClass myobj = new MyExternalClass();
            Console.WriteLine(myobj.ToString());
            Console.ReadKey();
        }
    }
}
