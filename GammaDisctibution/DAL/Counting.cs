using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GammaDisctibution.DAL
{
    public class Counting
    {
        public Counting(int uid, int x_value, double destribution_density, double destribution_function)
        {
            this.uid = uid;
            this.x_value = x_value;
            this.destribution_density = destribution_density;
            this.destribution_function = destribution_function;
        }

        public int uid { get; set; }
        public int x_value { get; set; }
        public double destribution_density { get; set; }
        public double destribution_function { get; set; }
    }
}
