using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedMethodsApp
{
    class Operations
    {
        public static int Calculation(int num)
        {
            int answer = num * -2;
            return answer;
        }

        public static int Calculation(double num)
        {
            int answer = (int)Math.Ceiling(num);
            return answer;
        }

        public static int Calculation(string num)
        {
            try
            {
                int convertedNum = Convert.ToInt32(num);
                int answer = convertedNum + 3;
                return answer;
            }
            catch(Exception e)
            {
                Console.WriteLine("Please enter an integer value.");
                return 0;
            }
        }
    }
}
