using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch09x03
{
    class Program
    {
        class MyClass
        {
            public int val;
        }

        struct MyStruct
        {
            public int val;
        }
        static void Main(string[] args)
        {
            MyClass objectA = new MyClass();
            MyClass objectB = objectA;
            objectA.val = 10;
            objectB.val = 20;
            MyStruct StructA = new MyStruct();
            MyStruct StructB = StructA;
            StructA.val = 30;
            StructB.val = 40;
            Console.WriteLine("ObjectA.val = {0}", objectA.val);
            Console.WriteLine("ObjectB.val = {0}", objectB.val);
            Console.WriteLine("StructA.val = {0}", StructA.val);
            Console.WriteLine("StructB.val = {0}", StructB.val);
            Console.ReadKey();
        }
    }
}
