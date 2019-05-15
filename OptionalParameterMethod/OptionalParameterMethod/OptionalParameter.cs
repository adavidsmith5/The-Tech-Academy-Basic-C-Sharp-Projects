using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterMethod
{
    public class OptionalParameter
    {
        public static int ForceOfGravity(int mass, int gravityConstant = 10)
        {

            int weight = mass * gravityConstant;

            return weight;
        }
    }
}
