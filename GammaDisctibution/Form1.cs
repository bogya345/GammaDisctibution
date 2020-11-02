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

namespace GammaDisctibution
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            this.counting_bindingSource.DataSource = new List<Counting>();
            this.chart_bindingSource.DataSource = new List<Charts>();
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
            this.chart_bindingSource.Add(new Charts(this.charts_dgv.Rows.Count, 1, 1));

            Series seria = environment.MakingSeria(this.charts_dgv.Rows.Count - 1, 1, 1);
            this.chart1.Series.Add(seria);
        }

        /// <summary>
        /// Замена точки на запятую -- но это пока что хер с ним - оно не работает
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void input_fix(object sender, DataGridViewCellEventArgs e)
        {
            if ((sender as DataGridView).Rows.Count != 0)
            {
                string tmp = "";
                switch ((sender as DataGridView).Name)
                {
                    case "charts_dgv":
                        {
                            tmp = this.charts_dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                            this.charts_dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = tmp.Replace('.', ',');
                            break;
                        }
                    case "counting_dgv":
                        {
                            this.charts_dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.charts_dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Replace('.', ',');
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }

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

    }

}
