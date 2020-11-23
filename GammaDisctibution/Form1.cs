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

            this.pdfViewer_function.LoadFromFile(environment.pdf_gamma_function);
            this.pdfViewer_distribution.LoadFromFile(environment.pdf_gamma_distribute);

            #endregion

            #region 1 Tab - 

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

            //this.chart1.Series.

            #endregion

            #region 2 Tab - 

            this.drawSeria(new object(), new EventArgs());

            #endregion

        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="series">0-распределение / 1-функция</param>
        private void addNewSeria(params Series[] series)
        {
            this.chart1_distribution.Series.Add(series[0]);
            this.chart1_functions.Series.Add(series[1]);

            this.chart1_distribution.Legends.Add(this.created_series.ToString());
            this.chart1_functions.Legends.Add(this.created_series.ToString());

            this.created_series++;
        }

        /// <summary>
        /// Добавление линии
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Series seria = environment.Create_Distribution_Seria(this.created_series, Convert.ToDouble(k_textBox.Text), Convert.ToDouble(o_textBox.Text));
            Series seria_func = environment.Create_Function_Seria(this.created_series, Convert.ToDouble(k_textBox.Text), Convert.ToDouble(o_textBox.Text));

            this.chart_bindingSource.Add(new Charts(this.created_series, Convert.ToDouble(k_textBox.Text), Convert.ToDouble(o_textBox.Text), seria.Color.ToArgb().ToString(), environment.last_points));

            this.addNewSeria(seria, seria_func);
        }

        /// <summary>
        /// Перерисовка измененной функции
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void charts_dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Series old_distribution_seria = chart1_distribution.Series[e.RowIndex];
            Series old_function_seria = chart1_functions.Series[e.RowIndex];

            string tmp = charts_dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            double k = Convert.ToDouble(charts_dgv.Rows[e.RowIndex].Cells[1].Value);
            double o = Convert.ToDouble(charts_dgv.Rows[e.RowIndex].Cells[2].Value);

            chart1_distribution.Series[e.RowIndex] = environment.Change_Distribution_Seria(old_distribution_seria, e.RowIndex, k, o);
            chart1_functions.Series[e.RowIndex] = environment.Change_Function_Seria(old_function_seria, e.RowIndex, k, o);

            chart1_distribution.Update();
            chart1_functions.Update();
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

        #region Change x limit
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
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox3.Text = (sender as TrackBar).Value.ToString();
            //environment.x_limit = Convert.ToDouble(textBox3.Text)
            //reload();
        }
        private void reload_1()
        {
            // rewrite
            int ind = 0;
            foreach (Charts i in Context.chartsList)
            {
                Series old_seria = chart1_distribution.Series[ind];
                string tmp = charts_dgv.Rows[ind].Cells[0].Value.ToString();
                double k = Convert.ToDouble(charts_dgv.Rows[ind].Cells[1].Value);
                double o = Convert.ToDouble(charts_dgv.Rows[ind].Cells[2].Value);

                chart1_distribution.Series[ind] = environment.Change_Distribution_Seria(old_seria, ind, k, o);
                chart1_functions.Series[ind] = environment.Change_Function_Seria(old_seria, ind, k, o);
                ind++;
            }

            chart1_distribution.Update();
        }
        #endregion

        private void calculate_params(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                // математическое ожидание
                double expected_value = Convert.ToDouble(textBox1.Text);

                // дисперсия
                double dispersion = Convert.ToDouble(textBox2.Text);

                // O
                double o_value = dispersion / expected_value;

                // K
                double k_value = expected_value / o_value;

                k_textBox.Text = Math.Round(k_value, 3).ToString();
                o_textBox.Text = Math.Round(o_value, 3).ToString();
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
                this.chart1_distribution.Series.RemoveAt(ind);
                this.chart1_distribution.Update();

                this.chart_bindingSource.RemoveAt(e.RowIndex);
                this.charts_dgv.Update();

                //this.chart1.Legends.Add(new Legend(Name))
            }
        }

        private void xRunner_Scroll(object sender, EventArgs e) { xValue_label.Text = xRunner.Value.ToString(); reload_2(); }
        private void limX2_trackBar_Scroll(object sender, EventArgs e)
        {
            string tmp = (sender as TrackBar).Value.ToString();
            environment.x_limit = Convert.ToDouble(limX2_textBox.Text);

            limX2_textBox.Text = tmp;

            if (Convert.ToInt32(tmp) < Convert.ToInt32(xValue_label.Text))
            {
                xRunner_Scroll(new object(), new EventArgs());
            }

            reload_2();
        }
        private void reload_2()
        {
            // распределение
            Series old_seria = chart2.Series[0];
            double k = Convert.ToDouble(k2_textBox.Text);
            double o = Convert.ToDouble(o2_textBox.Text);
            chart2.Series[0] = environment.Change_Distribution_Seria(old_seria, 0, k, o, 2);

            // значение x
            int x = Convert.ToInt32(xValue_label.Text);
            double y = chart2.Series[0].Points.FirstOrDefault(x_ => x_.XValue == x).YValues[0];
            chart2.Series[1].Points.Clear();
            chart2.Series[1].Points.AddXY(x, y);
            chart2.Series[1].Points.AddXY(x, 0);

            chart2.Update();
        }
        private void limX_textBox_TextChanged(object sender, EventArgs e)
        {
            xRunner.Maximum = Convert.ToInt32(limX2_textBox.Text);

            if ((sender as TextBox).Text != "")
            {
                if ((sender as TextBox).Text.Contains('.'))
                {
                    (sender as TextBox).Text = (sender as TextBox).Text.Replace('.', ',');
                }

                reload_2();
            }
        }

        private void calculate_params_2(object sender, EventArgs e)
        {
            if (M2_textBox.Text != "" && D2_textBox.Text != "")
            {
                // математическое ожидание
                double expected_value = Convert.ToDouble(textBox1.Text);

                // дисперсия
                double dispersion = Convert.ToDouble(textBox2.Text);

                // O
                double o_value = dispersion / expected_value;

                // K
                double k_value = expected_value / o_value;

                k2_textBox.Text = Math.Round(k_value, 3).ToString();
                o2_textBox.Text = Math.Round(o_value, 3).ToString();
            }
        }

        private void drawSeria(object sender, EventArgs e)
        {
            Series seria = environment.Create_Distribution_Seria(this.created_series, Convert.ToDouble(k_textBox.Text), Convert.ToDouble(o_textBox.Text), 2);
            //Series seria_func = environment.Create_Function_Seria(this.created_series, Convert.ToDouble(k_textBox.Text), Convert.ToDouble(o_textBox.Text));

            Charts tmp = new Charts(this.created_series, Convert.ToDouble(k2_textBox.Text), Convert.ToDouble(o2_textBox.Text), Color.FromName("Fuchsia").ToArgb().ToString(), environment.last_points);

            this.chart2.Series[0] = seria;

            reload_2();
        }
    }

}
