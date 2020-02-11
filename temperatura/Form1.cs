using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void v1_CheckedChanged(object sender, EventArgs e)
        {
            double converter, temp;
            temp = double.Parse(txt1.Text);
            converter = temp * 9 / 5 + 32;
            txt2.Text = converter.ToString();
                
        }

        private void v2_CheckedChanged(object sender, EventArgs e)
        {
            double converter, temp;
            temp = double.Parse(txt1.Text);
            converter = (temp-32)*5/9+273.15;
            txt2.Text = converter.ToString();

        }

        private void v3_CheckedChanged(object sender, EventArgs e)
        {
            double converter, temp;
            temp = double.Parse(txt1.Text);
            converter = temp+273.15;
            txt2.Text = converter.ToString();

        }

        private void v4_CheckedChanged(object sender, EventArgs e)
        {
            double converter, temp;
            temp = double.Parse(txt1.Text);
            converter = temp - 273.15;
            txt2.Text = converter.ToString();

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
