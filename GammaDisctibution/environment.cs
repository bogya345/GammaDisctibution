using System;
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
        public static string pdf_gamma_distribute
        {
            get
            {
                return @"../../View/gamma_distribution.pdf";
            }
            private set { }
        }
        public static string pdf_gamma_function
        {
            get
            {
                return @"../../View/gamma_function.pdf";
            }
            private set { }
        }


        private static Random rdm = new Random();

        public static double x_limit = 20;
        //public static double minimum_x_limit = -(int)environment.x_limit;
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

                for (int i = 0; i < environment.x_limit + 1; i++)
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

        public static IEnumerable<double> MyGammaFunction_Full(double k, double o)
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

                for (int i = 0; i < environment.x_limit + 1; i++)
                {
                    double gamma = SpecialFunctions.Gamma(k);
                    //double gamma = SpecialFunctions.GammaUpperIncomplete(k, i);

                    gamma = Math.Pow(gamma, i);

                    yield return gamma;
                }

                yield break;
            }
        }

        public static List<MyPoint> last_points_dustribution = new List<MyPoint>();
        //public static List<MyPoint> last_points_dustribution_2 = new List<MyPoint>();

        public static List<MyPoint> last_points_function = new List<MyPoint>();


        #region Распределение

        /// <summary>
        /// Создание функции(series) распределения
        /// </summary>
        /// <param name="index"></param>
        /// <param name="k"></param>
        /// <param name="o"></param>
        /// <returns></returns>
        public static Series Create_Distribution_Seria(int index, double k, double o, int indTab = 1)
        {
            Series seria = new Series(index.ToString());
            seria.LegendText = index.ToString();
            seria.ChartType = SeriesChartType.Line;

            /// в идеале надо бы сделать добовление по одной точке
            //for (int i = 0; i < 10; i++)
            //{
            //    seria.Points.AddXY(i, this.charts_dgv.Rows.Count);
            //}

            environment.Draw_Points_on_Distrbution_Seria(ref seria, index, k, o, indTab);

            return seria;
        }

        private static Series Draw_Points_on_Distrbution_Seria(ref Series seria, int index, double k, double o, int indTab = 1)
        {
            /// тут все точки сразу считаются и возвращаются в виде списка (есесена придется делать свой индекс)
            List<double> points = environment.MyGammaDistribution_Full(k, o).ToList();

            Charts chart;
            switch (indTab)
            {
                case 1:
                    {
                        chart = Context.chartsList.FirstOrDefault(x => x.uid == index);
                        break;
                    }
                case 2:
                    {
                        chart = Context.chartsList2.FirstOrDefault(x => x.uid == index);
                        break;
                    }
                default:
                    {
                        throw new Exception();
                    }
            }

            environment.last_points_dustribution.Clear();

            int ind = 1;
            if (chart == null)
            {
                foreach (double i in points)
                {
                    seria.Points.AddXY(ind, i);
                    environment.last_points_dustribution.Add(new MyPoint(ind, i));
                    ind++;
                }

                if (indTab != 2)
                {
                    seria.Color = Color.FromArgb(rdm.Next(256), rdm.Next(256), rdm.Next(256));
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

            return seria;
        }

        /// <summary>
        /// Замена точек функции(series) распределения
        /// </summary>
        /// <param name="old_seria">seria распределения</param>
        /// <param name="k"></param>
        /// <param name="o"></param>
        /// <returns></returns>
        public static Series Change_Distribution_Seria(Series old_seria, int index, double k, double o, int indTab = 1)
        {
            Series seria = old_seria;
            seria.Points.Clear();

            environment.Draw_Points_on_Distrbution_Seria(ref seria, index, k, o, indTab);

            return seria;
        }


        #endregion



        #region Плотность

        /// <summary>
        /// Создание функции(series) самой гамма функции
        /// </summary>
        /// <param name="index"></param>
        /// <param name="k"></param>
        /// <param name="o"></param>
        /// <returns></returns>
        public static Series Create_Function_Seria(int index, double k, double o)
        {
            Series seria = new Series(index.ToString());
            seria.LegendText = index.ToString();
            seria.ChartType = SeriesChartType.Point;

            environment.Draw_Points_on_Function_Seria(ref seria, index, k, o);

            return seria;
        }

        private static Series Draw_Points_on_Function_Seria(ref Series seria, int index, double k, double o)
        {
            /// тут все точки сразу считаются и возвращаются в виде списка (есесена придется делать свой индекс)
            List<double> points = environment.MyGammaFunction_Full(k, o).ToList();

            Charts chart = Context.chartsList.FirstOrDefault(x => x.uid == index);
            environment.last_points_function.Clear();

            //int ind = (int)environment.minimum_x_limit;
            int ind = 0;
            if (chart == null)
            {
                foreach (double i in points)
                {
                    //seria.Points.AddXY(ind, i);
                    //seria.Points
                    environment.last_points_function.Add(new MyPoint(ind, i));
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
        /// Замена точек функции(series) самой функции
        /// </summary>
        /// <param name="old_seria">seria функции (гамма)</param>
        /// <param name="k"></param>
        /// <param name="o"></param>
        /// <returns></returns>
        public static Series Change_Function_Seria(Series old_seria, int index, double k, double o)
        {
            Series seria = old_seria;
            seria.Points.Clear();

            environment.Draw_Points_on_Function_Seria(ref seria, index, k, o);

            return seria;
        }

        #endregion


    }
}
