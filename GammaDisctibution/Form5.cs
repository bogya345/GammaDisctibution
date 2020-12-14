using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GammaDisctibution
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public TabPage getPage1()
        {
            return this.exTab1;
        }

        public TabPage getPage(string tag)
        {
            switch (tag)
            {
                case "ex1tab": { return exTab1; }
                case "ex2tab": { return exTab2; }
                case "ex3tab": { return exTab3; }
                case "ex4tab": { return exTab4; }
                case "ex5tab": { return exTab5; }

                default:
                    {
                        throw new Exception();
                    }
            }
        }

        private void showSolution(object sender, EventArgs e)
        {
            switch ((sender as Button).Tag)
            {
                case "groupBox1": { groupBox1.Visible = !groupBox1.Visible; return; }
                case "groupBox2": { groupBox2.Visible = !groupBox2.Visible; return; }
                case "groupBox3": { groupBox3.Visible = !groupBox3.Visible; return; }
                case "groupBox4": { groupBox4.Visible = !groupBox4.Visible; return; }
                case "groupBox5": { groupBox5.Visible = !groupBox5.Visible; return; }
                default: { throw new Exception(); }
            }
        }
    }
}
