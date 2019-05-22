using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 3.224m;
            Console.WriteLine(number.Amount);
            Console.Read();
        }
    }
}
