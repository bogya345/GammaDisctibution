using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using MathNet.Numerics;
using MathNet.Numerics.Distributions;

namespace GammaDisctibution
{
    public static class environment
    {
        private static Random rdm = new Random();

        public static int x_limit = 20;

        public static List<double> MyGammaDistribution_Full(double k, double o)
        {
            if (!(k > 0 && o > 0))
            {
                // это ограничение должно соблюдаться
                /// K > 0
                /// o > 0
                throw new Exception();
            }
            else
            {

                List<double> resses = new List<double>();

                for (int i = 1; i < environment.x_limit + 1; i++)
                {
                    // prepare

                    double first = Math.Pow(i, k - 1);

                    double second_above = Math.Pow(Math.E, (-i / o));

                    double second_below = Math.Pow(o, k) * SpecialFunctions.Gamma(k);

                    // solving

                    double second = second_above / second_below;

                    double res = first * second;
                    resses.Add(res);

                }

                return resses;
            }
        }

        /// <summary>
        /// Создание функции(series)
        /// </summary>
        /// <param name="index"></param>
        /// <param name="k"></param>
        /// <param name="o"></param>
        /// <returns></returns>
        public static Series MakingSeria(int index, double k, double o)
        {
            Series seria = new Series(index.ToString());
            seria.LegendText = index.ToString();
            seria.ChartType = SeriesChartType.Line;

            /// в идеале надо бы сделать добовление по одной точке
            //for (int i = 0; i < 10; i++)
            //{
            //    seria.Points.AddXY(i, this.charts_dgv.Rows.Count);
            //}

            /// тут все точки сразу считаются и возвращаются в виде списка (есесена придется делать свой индекс)
            List<double> points = environment.MyGammaDistribution_Full(1, 1);
            int ind = 1;
            foreach (double i in points)
            {
                seria.Points.AddXY(ind, i);
                ind++;
            }

            seria.BorderWidth = 3;
            seria.Color = Color.FromArgb(rdm.Next(256), rdm.Next(256), rdm.Next(256));

            return seria;
        }

        /// <summary>
        /// Замена точек функции(series)
        /// </summary>
        /// <param name="old_seria"></param>
        /// <param name="k"></param>
        /// <param name="o"></param>
        /// <returns></returns>
        public static Series ChangeSeria(Series old_seria, double k, double o)
        {
            Series seria = old_seria;

            seria.Points.Clear();

            /// тут все точки сразу считаются и возвращаются в виде списка (есесена придется делать свой индекс)
            List<double> points = environment.MyGammaDistribution_Full(k, o);

            int ind = 1;
            foreach (double i in points)
            {
                seria.Points.AddXY(ind, i);
                ind++;
            }

            return seria;
        }


    }
}
