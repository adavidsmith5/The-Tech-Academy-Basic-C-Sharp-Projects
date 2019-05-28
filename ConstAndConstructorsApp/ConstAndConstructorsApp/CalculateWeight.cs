using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstAndConstructorsApp
{
    class CalculateWeight
    {
        public double mass;
        public double acceleration;
        public double weight;

        public CalculateWeight(double mass) : this(9.81, mass)
        {
        }
        public CalculateWeight(double acceleration, double mass)
        {
            this.acceleration = acceleration;
            this.mass = mass;
            this.weight = mass * acceleration;
        }
    }
}
