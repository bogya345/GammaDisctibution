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

        private static Random rdm = new Random();

        public static double x_limit1 = 20;
        public static double x_limit2 = 20;


        public static class memory
        {
            public static List<MyPoint> last_points = new List<MyPoint>();
        }

        /// <summary>
        /// Введение
        /// </summary>
        public static class introducing
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
        }


        public static class density
        {
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

                environment.density.Draw_Points_on_Seria(ref seria, index, k, o, 1);

                return seria;
            }

            /// <summary>
            /// Установление точек на Seria
            /// </summary>
            /// <param name="seria"></param>
            /// <param name="index"></param>
            /// <param name="k"></param>
            /// <param name="o"></param>
            /// <returns></returns>
            private static Series Draw_Points_on_Seria(ref Series seria, int index, double k, double o, int indTab)
            {

                switch (indTab)
                {
                    case 1:
                        {
                            /// тут все точки сразу считаются и возвращаются в виде списка (есесена придется делать свой индекс)
                            List<double> points = environment.density.MyGammaDensity_Full(k, o, environment.x_limit1).ToList();

                            Charts chart = Context.chart1_density_List.FirstOrDefault(x => x.uid == index);
                            environment.memory.last_points.Clear();

                            int ind = 1;
                            if (chart == null)
                            {
                                foreach (double i in points)
                                {
                                    seria.Points.AddXY(ind, i);
                                    environment.memory.last_points.Add(new MyPoint(ind, i));
                                    ind++;
                                }
                                seria.Color = Color.FromArgb(rdm.Next(256), rdm.Next(256), rdm.Next(256));
                            }
                            else
                            {
                                foreach (double i in points)
                                {
                                    seria.Points.AddXY(ind, i);
                                    chart.appendPoint(ind, i);
                                    environment.memory.last_points.Add(new MyPoint(ind, i));
                                    ind++;
                                }
                            }
                            seria.BorderWidth = 3;

                            return seria;
                        }

                    case 2:
                        {
                            /// тут все точки сразу считаются и возвращаются в виде списка (есесена придется делать свой индекс)
                            List<double> points = environment.density.MyGammaDensity_Full(k, o, environment.x_limit2).ToList();

                            if (Context.singleChart != null)
                            {
                                Context.singleChart.clearPoints();
                            }
                            environment.memory.last_points.Clear();

                            int ind = 1;
                            foreach (double i in points)
                            {
                                seria.Points.AddXY(ind, i);
                                if (Context.singleChart != null) { Context.singleChart.appendPoint(ind, i); }
                                environment.memory.last_points.Add(new MyPoint(ind, i));
                                ind++;
                            }

                            seria.BorderWidth = 3;

                            return seria;
                        }
                }

                return seria;
            }

            /// <summary>
            /// Замена точек функции(series)
            /// </summary>
            /// <param name="old_seria"></param>
            /// <param name="k"></param>
            /// <param name="o"></param>
            /// <returns></returns>
            public static Series ChangeSeria(Series old_seria, int index, double k, double o, int indTab = 1)
            {
                Series seria = old_seria;
                seria.Points.Clear();

                environment.density.Draw_Points_on_Seria(ref seria, index, k, o, indTab);

                List<MyPoint> tmp = new List<MyPoint>();
                foreach (var i in seria.Points)
                {
                    tmp.Add(new MyPoint(i.XValue, i.YValues[0]));
                }
                Context.singleChart = new Charts(0, k, o, old_seria.Color.ToArgb().ToString(), tmp);

                return seria;
            }

            /// <summary>
            /// Вычисление точек гамма-функции полностью
            /// </summary>
            /// <param name="k"></param>
            /// <param name="o"></param>
            /// <returns></returns>
            /// <returns></returns>
            public static IEnumerable<double> MyGammaDensity_Full(double k, double o, double x_limit)
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

                    for (double i = 0; i < x_limit + 1; i = Math.Round(i + 1, 3))
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


        }

        public static class distribution
        {
            public static Series Draw_Points_on_Seria(ref Series seria, int index, double k, double o, int indTab)
            {
                switch (indTab)
                {
                    case 1:
                        {
                            /// тут все точки сразу считаются и возвращаются в виде списка (есесена придется делать свой индекс)
                            List<double> points = environment.density.MyGammaDensity_Full(k, o, environment.x_limit1).ToList();

                            Charts chart = Context.chart1_density_List.FirstOrDefault(x => x.uid == index);
                            environment.memory.last_points.Clear();

                            int ind = 1;
                            if (chart == null)
                            {
                                foreach (double i in points)
                                {
                                    seria.Points.AddXY(ind, i);
                                    environment.memory.last_points.Add(new MyPoint(ind, i));
                                    ind++;
                                }
                                seria.Color = Color.FromArgb(rdm.Next(256), rdm.Next(256), rdm.Next(256));
                            }
                            else
                            {
                                foreach (double i in points)
                                {
                                    seria.Points.AddXY(ind, i);
                                    chart.appendPoint(ind, i);
                                    environment.memory.last_points.Add(new MyPoint(ind, i));
                                    ind++;
                                }
                            }
                            seria.BorderWidth = 3;

                            return seria;
                        }

                    case 2:
                        {
                            /// тут все точки сразу считаются и возвращаются в виде списка (есесена придется делать свой индекс)
                            List<double> points = environment.density.MyGammaDensity_Full(k, o, environment.x_limit2).ToList();

                            Charts chart = Context.singleChart;
                            environment.memory.last_points.Clear();

                            int ind = 1;

                            foreach (double i in points)
                            {
                                seria.Points.AddXY(ind, i);
                                if (chart != null) { chart.appendPoint(ind, i); }
                                environment.memory.last_points.Add(new MyPoint(ind, i));
                                ind++;
                            }

                            seria.BorderWidth = 3;

                            return seria;
                        }
                }

                return seria;
            }

            /// <summary>
            /// Вычисление точек гамма-функции распределение
            /// </summary>
            /// <param name="k"></param>
            /// <param name="o"></param>
            /// <returns></returns>
            /// <returns></returns>
            public static IEnumerable<double> MyGammaDistribution_Full(List<double> sample, double x_limit)
            {
                List<double> res = new List<double>();

                /// говорят тема херня, но почти работало
                //res.Add(0);
                //for (int i = 1; i < sample.Count; i++)
                //{
                //    res.Add(sample[i] + res.Last());
                //}

                for (int i = 0; i < sample.Count - 1; i++)
                {
                    double tmp = Math.Round(sample[i] + sample[i + 1], 2) / 2;
                    res.Add(tmp);
                }

                return res;
            }

            public static Series ChangeSeria(Series old_seria, int index, int indTab = 1)
            {
                Series seria = old_seria;
                seria.Points.Clear();
                seria.Points.AddXY(0, 0);

                switch (indTab)
                {
                    case 1:
                        {
                            int ind = 1;
                            seria.Points.AddXY(0, 0);
                            foreach (MyPoint i in environment.memory.last_points)
                            {
                                seria.Points.AddXY(i.X, (i.Y + seria.Points.Last().YValues[0]));
                            }

                            break;
                        }

                    case 2:
                        {
                            foreach (MyPoint i in environment.memory.last_points)
                            {
                                seria.Points.AddXY(i.X, (i.Y + seria.Points.Last().YValues[0]));
                            }

                            break;
                        }

                    default:
                        {
                            throw new Exception();
                        }
                }

                //environment.distribution.Draw_Points_on_Seria(ref seria, index, indTab);

                //seria.ChartType = SeriesChartType.Column;

                return seria;
            }


        }

        public static Series CreateSeria(Color color, List<MyPoint> points)
        {
            Series seria = new Series();

            seria.Color = color;

            foreach (MyPoint i in points)
            {
                seria.Points.AddXY(i.X, i.Y);
            }

            return seria;
        }


    }
}
