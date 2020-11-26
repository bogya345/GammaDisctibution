using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
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

        private int created_series = 0;

        public Form1()
        {
            InitializeComponent();

            #region Introducing

            this.pdfViewer_function.LoadFromFile(environment.introducing.pdf_gamma_function);
            this.pdfViewer_distribution.LoadFromFile(environment.introducing.pdf_gamma_distribute);

            #endregion

            #region DataGridVie header

            //this.counting_bindingSource.DataSource = new List<Counting>();
            this.chart_bindingSource.DataSource = Context.chartsList;

            //Context.chartsList.Add(new Charts(999, 1, 1, Color.White.ToArgb().ToString()));

            // настройка ширины столбцов и их имен
            this.charts_dgv.Columns[0].HeaderText = "#";  // uid
            this.charts_dgv.Columns[0].Width = 25;

            this.charts_dgv.Columns[1].HeaderText = "K";   // k_value
            this.charts_dgv.Columns[1].Width = 50;

            this.charts_dgv.Columns[2].HeaderText = "θ";   // o_value
            this.charts_dgv.Columns[2].Width = 50;

            this.charts_dgv.Columns[3].HeaderText = "";   // color
            this.charts_dgv.Columns[3].Width = 30;

            this.charts_dgv.Columns[4].HeaderText = "Del";  // delete cell (btn)
            this.charts_dgv.Columns[4].Width = 35;

            #endregion

            #region other



            #endregion
        }


        #region 1 Tab - Введение

        #endregion


        #region 2 Tab - Функции

        /// <summary>
        /// Добавление линии
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (k1_textBox.Text.Contains('.')) { k1_textBox.Text = k1_textBox.Text.Replace('.', ','); }
            if (o1_textBox.Text.Contains('.')) { o1_textBox.Text = o1_textBox.Text.Replace('.', ','); }

            Series seria = environment.series.CreateSeria(this.created_series, Convert.ToDouble(k1_textBox.Text), Convert.ToDouble(o1_textBox.Text));
            this.chart_bindingSource.Add(
                new Charts(this.created_series, Convert.ToDouble(k1_textBox.Text), Convert.ToDouble(o1_textBox.Text), seria.Color.ToArgb().ToString(), environment.memory.last_points)
                );
            this.chart1.Series.Add(seria);
            this.created_series++;
        }

        /// <summary>
        /// Перерисовка измененной функции
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void charts_dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Series old_seria = chart1.Series[e.RowIndex];
            string tmp = charts_dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            double k = Convert.ToDouble(charts_dgv.Rows[e.RowIndex].Cells[1].Value);
            double o = Convert.ToDouble(charts_dgv.Rows[e.RowIndex].Cells[2].Value);

            chart1.Series[e.RowIndex] = environment.series.ChangeSeria(old_seria, e.RowIndex, k, o);

            chart1.Update();
        }

        private void charts_dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                Charts tmp = Context.chartsList.FirstOrDefault(x => x.uid.ToString() == this.charts_dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (tmp != null)
                    charts_dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = tmp.getTrueColor();
            }
        }

        private void beautyNum(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Back || (sender as TextBox).Text.Length != 0)
            {
                if ((sender as TextBox).Text.Last() == ',' || (sender as TextBox).Text.Last() == '.')
                {
                    //(sender as TextBox).Text = Convert.ToDouble((sender as TextBox).Text).ToString("#,#", culture);
                }
                else
                {
                    var culture = new CultureInfo("ru-RU");
                    (sender as TextBox).Text = Convert.ToDouble((sender as TextBox).Text).ToString("#,#", culture);
                }
             (sender as TextBox).Select((sender as TextBox).Text.Length, (sender as TextBox).Text.Length);
            }
        }

        private void charts_dgv_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.FormattedValue.ToString().Contains('.'))
            {
                //string tmp =.ToString();
                string tmp2 = e.FormattedValue.ToString();
                (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = tmp2.Replace('.', ',');
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text != "")
            {
                if ((sender as TextBox).Text.Contains('.'))
                {
                    (sender as TextBox).Text = (sender as TextBox).Text.Replace('.', ',');
                }

                environment.x_limit = Convert.ToDouble((sender as TextBox).Text);

                reload_1();
            }
        }

        /// <summary>
        /// Для изменения X
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox3.Text = (sender as TrackBar).Value.ToString();
            //environment.x_limit = Convert.ToDouble(textBox3.Text)
            //reload();
        }

        /// <summary>
        /// Перерисовка chart1
        /// </summary>
        private void reload_1()
        {
            int ind = 0;
            foreach (Charts i in Context.chartsList)
            {
                Series old_seria = chart1.Series[ind];
                string tmp = charts_dgv.Rows[ind].Cells[0].Value.ToString();
                double k = Convert.ToDouble(charts_dgv.Rows[ind].Cells[1].Value);
                double o = Convert.ToDouble(charts_dgv.Rows[ind].Cells[2].Value);

                chart1.Series[ind] = environment.series.ChangeSeria(old_seria, ind, k, o);
                ind++;
            }

            chart1.Update();
        }


        #endregion


        #region 3 Tab - Подсчет

        #endregion


        #region 3 Tab - Примеры

        #endregion


        private void calculate_params(object sender, EventArgs e)
        {
            if (M1_textBox.Text != "" && D1_textBox.Text != "")
            {
                // математическое ожидание
                double expected_value = Convert.ToDouble(M1_textBox.Text);

                // дисперсия
                double dispersion = Convert.ToDouble(D1_textBox.Text);

                // O
                double o_value = dispersion / expected_value;

                // K
                double k_value = expected_value / o_value;

                k1_textBox.Text = Math.Round(k_value, 3).ToString();
                o1_textBox.Text = Math.Round(o_value, 3).ToString();
            }

        }

        private void charts_dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            (this.charts_dgv.Rows[this.charts_dgv.Rows.Count - 1].Cells[4] as DataGridViewButtonCell).Value = "DEL";
        }

        private void charts_dgv_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            // ячейка для удаления строки
            if (e.ColumnIndex == 4)
            {
                int ind = Convert.ToInt32(this.charts_dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
                this.chart1.Series.RemoveAt(ind);
                this.chart1.Update();

                this.chart_bindingSource.RemoveAt(e.RowIndex);
                this.charts_dgv.Update();
            }
        }
    }

}
