using GammaDisctibution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace GammaDisctibution.DAL
{
    static class Context
    {
        //public static Charts[] chartsList;
        //public static List<Charts> chart1_distribution_List = new List<Charts>();
        public static List<Charts> chart1_density_List = new List<Charts>();

        public static Charts singleChart;
    }
}
