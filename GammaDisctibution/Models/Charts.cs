using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace GammaDisctibution.Models
{
    public class Charts
    {
        public Charts(int uid, double k_value, double o_value, string color, List<MyPoint> points)
        {
            this.uid = uid;
            this.k_value = k_value;
            this.o_value = o_value;
            this.color = color;
            this.points_density = new List<MyPoint>(points);

            this.points_distribution = new List<MyPoint>();
            //this.points_distribution.Add(new MyPoint(0, 0));

            for (int i = 0; i < this.points_density.Count - 1; i++)
            {
                /// сказали так низя, но оно вроде и можно
                //points_distribution.Add(new MyPoint(i, (this.points_density[i].Y + this.points_distribution.Last().Y)));

                double tmp;

                //double tmp = Math.Round(((this.points_density[i].Y + this.points_density[i + 1].Y) / 2), 1);
                if (this.points_distribution.Count == 0)
                {
                    tmp = Math.Round(((this.points_density[i].Y + this.points_density[i + 1].Y) / 2) + 0.0, 2);
                }
                else
                {
                    tmp = Math.Round(((this.points_density[i].Y + this.points_density[i + 1].Y) / 2) + points_distribution.Last().Y, 2);
                }

                points_distribution.Add(new MyPoint(i, tmp));
            }

        }

        public int uid { get; set; }
        public double k_value { get; set; }
        public double o_value { get; set; }

        public string color { get { return ""; } set { this.color_ = Color.FromArgb(int.Parse(value)); } }
        public Color getTrueColor() { return this.color_; }
        private Color color_;


        private List<MyPoint> points_density = new List<MyPoint>();
        public List<MyPoint> getPoints_density() { return this.points_density; }
        //public void setPoints(List<Point> points) { this.clearPoints(); this.points = new List<Point>(points); }
        //public void appendPoint(Point point) { this.points.Add(new MyPoint(); }
        public void appendPoint(double x, double y) { this.points_density.Add(new MyPoint(x, y)); }
        public void clearPoints() { this.points_density.Clear(); this.points_distribution.Clear(); }


        private List<MyPoint> points_distribution = new List<MyPoint>();
        public List<MyPoint> getPoints_distribution() { return this.points_distribution; }


        public Series getDistributionAsSeria()
        {
            Series ser = new Series();
            ser.Color = Color.Orange;

            foreach (MyPoint i in this.points_distribution)
            {
                ser.Points.AddXY(i.X, i.Y);
            }

            return ser;
        }

        public override string ToString()
        {
            return string.Format("#{0} -- K= {1} | O= {2}", uid, k_value, o_value);
        }
    }

    public class MyPoint
    {
        public double X { get; set; }
        public double Y { get; set; }

        public MyPoint(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return string.Format("X=={0},Y=={1}", this.X, this.Y);
        }
    }
}
