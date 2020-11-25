using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate void Procedure();

namespace Section13
{
    class DelegateDemo
    {
        public static void Method1()
        {
            Console.WriteLine("Method1");
        }

        public static void Method2()
        {
            Console.WriteLine("Method2");
        }

        public void Method3()
        {
            Console.WriteLine("Method3");
        }

        public static void Main()
        {
            Procedure someProcs = null;

            someProcs += new Procedure(DelegateDemo.Method1);
            someProcs += new Procedure(Method2); //omitted class name

            DelegateDemo demo = new DelegateDemo();

            someProcs += new Procedure(demo.Method3);
            someProcs();
        }
    }
}
