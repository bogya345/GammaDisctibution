using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GammaDisctibution
{
    public partial class Form4 : Form
    {
        public Form4(Series ser1, Series ser2)
        {
            InitializeComponent();

            this.chart2.Series.Clear();
            this.chart2.Legends.Clear();
            this.chart2.Series.Add(ser1);

            this.chart1.Series.Clear();
            this.chart1.Legends.Clear();
            this.chart1.Series.Add(ser2);
        }
    }
}
