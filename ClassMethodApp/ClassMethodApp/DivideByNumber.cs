using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodApp
{
    public class DivideByNumber
    {

        public void DivideEvenly(int input, out string isThereRemainder, out int quotient, out int remainder, string dividedBy = "2")
        {
            if(dividedBy != "")
            {
                int divisor = Convert.ToInt32(dividedBy);
                result = input / divisor;
                if (input % divisor == 0)
                {
                    isThereRemainder = divisor + " is a factor of " + input;
                    quotient = input / divisor;
                    remainder = 0;
                }
                else
                {
                    isThereRemainder = input + " is not divisible by " + divisor;
                    double answer = input / divisor;
                    quotient = (int)Math.Floor(answer);
                    remainder = input % divisor;
                }
            }
            else
            {
                int divisor = 2;
                result = input / divisor;
                if (input % divisor == 0)
                {
                    isThereRemainder = divisor + " is a factor of " + input;
                    quotient = input / divisor;
                    remainder = 0;
                }
                else
                {
                    isThereRemainder = input + " is not divisible by " + divisor;
                    double answer = input / divisor;
                    quotient = (int)Math.Floor(answer);
                    remainder = input % divisor;
                }
            }
            
        }

        public DivideByNumber()
        {
            result = 0;
        }

        

        public int result { get; set; }
        
    }
}
