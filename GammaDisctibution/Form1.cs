using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using GammaDisctibution.DAL;
using GammaDisctibution.Models;

namespace GammaDisctibution
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            //this.counting_bindingSource.DataSource = new List<Counting>();
            this.chart_bindingSource.DataSource = Context.chartsList;

            // настройка ширины столбцов
            this.charts_dgv.Columns[0].Width = 40;   // uid
            this.charts_dgv.Columns[1].Width = 60;   // k_value
            this.charts_dgv.Columns[2].Width = 60;   // o_value
            this.charts_dgv.Columns[3].Width = 40;   // color
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Добавление линии
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Series seria = environment.MakingSeria(this.charts_dgv.Rows.Count - 1, 1, 1);
            this.chart_bindingSource.Add(new Charts(this.charts_dgv.Rows.Count, 1, 1, seria.Color.ToArgb().ToString()));
            this.chart1.Series.Add(seria);
        }

        /// <summary>
        /// Перерисовка измененной функции
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void charts_dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Series old_seria = chart1.Series[e.RowIndex];
            double k = Convert.ToDouble(charts_dgv.Rows[e.RowIndex].Cells[0].Value);
            double o = Convert.ToDouble(charts_dgv.Rows[e.RowIndex].Cells[1].Value);

            chart1.Series[e.RowIndex] = environment.ChangeSeria(old_seria, k, o);

            chart1.Update();
        }

        private void charts_dgv_KeyUp(object sender, KeyEventArgs e)
        {
            //e.KeyVa
        }

        private void charts_dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                charts_dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Context.chartsList.FirstOrDefault(x => x.uid == e.RowIndex).getTrueColor();
            }
        }
    }

}
