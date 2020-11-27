using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this.points_distribution.Add(new MyPoint(0, 0));

            for (int i = 1; i < this.points_density.Count; i++)
            {
                points_distribution.Add(new MyPoint(i, (this.points_density[i].Y + this.points_distribution.Last().Y)));
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
    }
}
