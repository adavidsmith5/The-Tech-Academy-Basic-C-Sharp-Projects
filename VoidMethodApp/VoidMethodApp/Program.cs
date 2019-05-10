using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            VoidMethod method = new VoidMethod();
            VoidMethod.QuickMath(num1: 5, num2: 6);

            Console.Read();
        }
    }
}
