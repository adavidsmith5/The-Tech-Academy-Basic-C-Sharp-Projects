using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodApp
{
    static class PrimeNumbers
    {
        public static string PrimeNumberDefinition;
        public static string NotPrime;
        public static string MaybePrime;
        static PrimeNumbers()
        {
            PrimeNumberDefinition = "A prime number is a number that is only divisible by 1 and itself.";
            NotPrime = "Your number is not a prime number.";
            MaybePrime = "Your number may be a prime number.";
        }

        
    }
}
