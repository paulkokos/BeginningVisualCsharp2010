using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch09x01
{
    public abstract class MyBase
    {
        
    }

    internal class Myclass : MyBase
    {
        
    }

    public interface IMyBaseInterface
    {
        
    }

    internal interface IMyBaseInterface2
    {
        
    }

    internal interface IMyInterface : IMyBaseInterface, IMyBaseInterface2
    {
        
    }

    internal sealed class MyComplexClass : Myclass, IMyInterface
    {
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyComplexClass myobj = new MyComplexClass();
            Console.WriteLine(myobj.ToString());
            Console.ReadKey();
        }
    }
}
