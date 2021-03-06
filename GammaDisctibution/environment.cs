﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using MathNet.Numerics;
using MathNet.Numerics.Distributions;
using GammaDisctibution.DAL;
using GammaDisctibution.Models;
using System.Security.Policy;

namespace GammaDisctibution
{
    public static class environment
    {
        public static string html_gamma_distribute
        {
            get
            {
                //using (StreamReader sr = new StreamReader("./Views/introducing.html"))
                using (StreamReader sr = new StreamReader("../../View/test.html"))
                {
                    string[] kek;

                    string tmp = sr.ReadToEnd().Replace("\r\n", "");

                    return string.Format("{0}", tmp);
                }
            }
            set { }
        }

        public static string html_gamma_function
        {
            get
            {
                //using (StreamReader sr = new StreamReader("./Views/introducing.html"))
                using (StreamReader sr = new StreamReader("../../View/gamma_func.html"))
                {
                    string[] kek;

                    string tmp = sr.ReadToEnd().Replace("\r\n", "");

                    return string.Format("{0}", tmp);
                }
            }
            set { }
        }


        private static Random rdm = new Random();

        public static double x_limit = 20;
        public static void Repaint_Series()
        {

        }

        public static IEnumerable<double> MyGammaDistribution_Full(double k, double o)
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

                //List<double> resses = new List<double>();

                for (int i = 1; i < environment.x_limit + 1; i++)
                {
                    // prepare

                    double first = Math.Pow(i, k - 1);

                    double second_above = Math.Pow(Math.E, (-i / o));

                    double gamma = SpecialFunctions.Gamma(k);
                    double second_below = Math.Pow(o, k) * gamma;

                    // solving

                    double second = second_above / second_below;

                    double res = first * second;



                    yield return res;

                }

                yield break;
            }
        }

        public static List<MyPoint> last_points = new List<MyPoint>();

        /// <summary>
        /// Создание функции(series)
        /// </summary>
        /// <param name="index"></param>
        /// <param name="k"></param>
        /// <param name="o"></param>
        /// <returns></returns>
        public static Series CreateSeria(int index, double k, double o)
        {
            Series seria = new Series(index.ToString());
            seria.LegendText = index.ToString();
            seria.ChartType = SeriesChartType.Line;

            /// в идеале надо бы сделать добовление по одной точке
            //for (int i = 0; i < 10; i++)
            //{
            //    seria.Points.AddXY(i, this.charts_dgv.Rows.Count);
            //}

            environment.Draw_Points_on_Seria(ref seria, index, k, o);

            return seria;
        }

        private static Series Draw_Points_on_Seria(ref Series seria, int index, double k, double o)
        {
            /// тут все точки сразу считаются и возвращаются в виде списка (есесена придется делать свой индекс)
            List<double> points = environment.MyGammaDistribution_Full(k, o).ToList();

            Charts chart = Context.chartsList.FirstOrDefault(x => x.uid == index);
            environment.last_points.Clear();

            int ind = 1;
            if (chart == null)
            {
                foreach (double i in points)
                {
                    seria.Points.AddXY(ind, i);
                    environment.last_points.Add(new MyPoint(ind, i));
                    ind++;
                }
            }
            else
            {
                foreach (double i in points)
                {
                    seria.Points.AddXY(ind, i);
                    chart.appendPoint(ind, i);
                    ind++;
                }
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
        public static Series ChangeSeria(Series old_seria, int index, double k, double o)
        {
            Series seria = old_seria;
            seria.Points.Clear();

            environment.Draw_Points_on_Seria(ref seria, index, k, o);

            return seria;
        }


    }
}
