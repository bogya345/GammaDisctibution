using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GammaDisctibution.DAL
{
    public class Charts
    {
        public Charts(int uid, double k_value, double o_value)
        {
            this.uid = uid;
            this.k_value = k_value;
            this.o_value = o_value;
        }

        public int uid { get; set; }
        public double k_value { get; set; }
        public double o_value { get; set; }

        public override string ToString()
        {
            return string.Format("#{0} -- K= {1} | O= {2}", uid, k_value, o_value);
        }
    }
}
