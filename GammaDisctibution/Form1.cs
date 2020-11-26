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

            #region 3 tab prepare

            //this.drawSeria(new object(), new EventArgs());

            reload_2();

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
            //Context.chartsList.Add(
            //    new Charts(this.created_series, Convert.ToDouble(k1_textBox.Text), Convert.ToDouble(o1_textBox.Text), seria.Color.ToArgb().ToString(), environment.memory.last_points)
            //    );
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

        /// <summary>
        /// Для показа цвета
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void charts_dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                Charts tmp = Context.chartsList.FirstOrDefault(x => x.uid.ToString() == this.charts_dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (tmp != null)
                    charts_dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = tmp.getTrueColor();
            }
        }

        /// <summary>
        /// Нажатие на ячейки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void charts_dgv_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            // ячейка для выбора цвета
            if (e.ColumnIndex == 3)
            {
                if (this.colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    //this.charts_dgv.Rows[e.RowIndex].Cells[3].Value = "";

                    this.charts_dgv.Rows[e.RowIndex].Cells[3].Style.BackColor = this.colorDialog1.Color;
                    Context.chartsList.FirstOrDefault(x => x.uid == e.RowIndex).color = this.colorDialog1.Color.ToArgb().ToString();
                    //item
                    this.chart_bindingSource.DataSource = null;
                    this.chart_bindingSource.DataSource = Context.chartsList;

                    this.chart1.Series[e.RowIndex].Color = this.colorDialog1.Color;

                    reload_1();
                    this.charts_dgv.Refresh();
                }
            }

            // ячейка для удаления строки
            if (e.ColumnIndex == 4)
            {
                if (MessageBox.Show("Вы уверены?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("А я бы на вашем месте не был бы так уверен");
                    int ind = Convert.ToInt32(this.charts_dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
                    this.chart1.Series.RemoveAt(ind);
                    this.chart1.Update();

                    this.chart_bindingSource.RemoveAt(e.RowIndex);
                    this.charts_dgv.Update();
                }
            }
        }

        /// <summary>
        /// Думаю можно забить на это
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void charts_dgv_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.FormattedValue.ToString().Contains('.'))
            {
                //string tmp =.ToString();
                string tmp2 = e.FormattedValue.ToString();
                (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = tmp2.Replace('.', ',');
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text != "")
            {
                if ((sender as TextBox).Text.Contains('.'))
                {
                    (sender as TextBox).Text = (sender as TextBox).Text.Replace('.', ',');
                }

                environment.x_limit1 = Convert.ToDouble((sender as TextBox).Text);

                reload_1();
            }
        }

        /// <summary>
        /// Добавление кнопки удаления и показа плотности
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void charts_dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            (this.charts_dgv.Rows[this.charts_dgv.Rows.Count - 1].Cells[4] as DataGridViewButtonCell).Value = "DEL";
            (this.charts_dgv.Rows[this.charts_dgv.Rows.Count - 1].Cells[5] as DataGridViewButtonCell).Value = "Плотность";
        }


        /// <summary>
        /// Для изменения X
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            x_limit1_textBox.Text = (sender as TrackBar).Value.ToString();
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

        private void change_xRunner(object sender, EventArgs e)
        {
            xValue_label.Text = xRunner.Value.ToString();
            reload_2();
        }

        private void change_x_lim2(object sender, EventArgs e)
        {
            x_limit2_textBox.Text = (sender as TrackBar).Value.ToString();
            environment.x_limit2 = (sender as TrackBar).Value;
        }

        private void change_x_limit2_textBox(object sender, EventArgs e)
        {
            if (true)
            {
                xRunner.Maximum = Convert.ToInt32(x_limit2_textBox.Text);

                if ((sender as TextBox).Text != "")
                {
                    if ((sender as TextBox).Text.Contains('.'))
                    {
                        (sender as TextBox).Text = (sender as TextBox).Text.Replace('.', ',');
                    }

                    reload_2();
                }
            }
        }

        private void reload_2()
        {
            // распределение
            Series old_seria = chart2.Series[0];
            double k = Convert.ToDouble(k2_textBox.Text);
            double o = Convert.ToDouble(o2_textBox.Text);
            chart2.Series[0] = environment.series.ChangeSeria(old_seria, 0, k, o, 2);

            Context.singleChart = new Charts(0, 1, 1, Color.Blue.ToArgb().ToString(), environment.memory.last_points);

            // значение x
            int x = Convert.ToInt32(xValue_label.Text);
            double y = chart2.Series[0].Points.FirstOrDefault(x_ => x_.XValue == x).YValues[0];
            yValue_label.Text = Math.Round(y, 5).ToString();
            chart2.Series[1].Points.Clear();
            chart2.Series[1].Points.AddXY(x, y);
            chart2.Series[1].Points.AddXY(x, 0);

            chart2.Update();
        }

        #endregion


        #region 4 Tab - Примеры

        #endregion


        #region 2 & 3 Tabs

        private void calculate_params(object sender, EventArgs e)
        {
            if ((sender as TextBox).Name.Contains("M1") || (sender as TextBox).Name.Contains("D1"))
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
                return;
            }

            if ((sender as TextBox).Name.Contains("M2") || (sender as TextBox).Name.Contains("D2"))
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
                return;
            }

        }

        #endregion

    }

}
