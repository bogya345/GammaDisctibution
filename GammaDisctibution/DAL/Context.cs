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
        public static List<Charts> chartsList = new List<Charts>();

        /// <summary>
        /// 0 - распределение
        /// 1 - значение x
        /// </summary>
        public static List<Charts> chartsList2 = new List<Charts>();
    }
}
