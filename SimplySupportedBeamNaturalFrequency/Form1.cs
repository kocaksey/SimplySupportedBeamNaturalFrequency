using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplySupportedBeamNaturalFrequency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double fn = 0;
        double[] knArray = { 9.87, 39.5, 88.8, 158, 247 };
        double[] ResultArray = new double[5];
        //s
        private void btnCalculateCant_Click(object sender, EventArgs e)
        {
            double elasticity;
            double inertia;
            double beamLength;
            double w;
            int j = 0;
            double g = 9806.0;
            double.TryParse(txtElCant.Text, out elasticity);
            double.TryParse(txtInCant.Text, out inertia);
            double.TryParse(txtBeamCant.Text, out beamLength);
            double.TryParse(txtWCant.Text, out w);
            if (txtElCant.Text == "" || txtInCant.Text == "" || txtBeamCant.Text == "" || txtWCant.Text == "")
            {
                MessageBox.Show("Please enter values!", "Warning!");
            }
            else
            {

                foreach (double kn in knArray)
                {
                    fn = ((kn / (2.0 * Math.PI)) * Math.Sqrt((elasticity * inertia * g * 1000) / (w * Math.Pow(beamLength, 4))));
                    fn = Math.Round(fn, 2);
                    ResultArray[j] = fn;
                    j += 1;
                }
                lbRsCant1.Text = Convert.ToString(ResultArray[0]);
                lbRsCant2.Text = Convert.ToString(ResultArray[1]);
                lbRsCant3.Text = Convert.ToString(ResultArray[2]);
                lbRsCant4.Text = Convert.ToString(ResultArray[3]);
                lbRsCant5.Text = Convert.ToString(ResultArray[4]);
                hz1.Visible = true;
                hz2.Visible = true;
                hz3.Visible = true;
                hz4.Visible = true;
                hz5.Visible = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtWCant.Text = "";
            txtBeamCant.Text = "";
            txtInCant.Text = "";
            txtElCant.Text = "";
            hz1.Visible = false;
            hz2.Visible = false;
            hz3.Visible = false;
            hz4.Visible = false;
            hz5.Visible = false;
            lbRsCant1.Text = "";
            lbRsCant2.Text = "";
            lbRsCant3.Text = "";
            lbRsCant4.Text = "";
            lbRsCant5.Text = "";
        }

        private void txtElCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
            if (txtElCant.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtElCant.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (txtElCant.Text.StartsWith("0") && !txtElCant.Text.StartsWith("0.") && e.KeyChar != '\b' && e.KeyChar != (int)'.')
            {
                e.Handled = true;
            }
        }

        private void txtInCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
            if (txtInCant.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtInCant.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (txtInCant.Text.StartsWith("0") && !txtInCant.Text.StartsWith("0.") && e.KeyChar != '\b' && e.KeyChar != (int)'.')
            {
                e.Handled = true;
            }
        }

        private void txtBeamCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
            if (txtBeamCant.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtBeamCant.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (txtBeamCant.Text.StartsWith("0") && !txtBeamCant.Text.StartsWith("0.") && e.KeyChar != '\b' && e.KeyChar != (int)'.')
            {
                e.Handled = true;
            }
        }

        private void txtWCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
            if (txtWCant.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtWCant.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (txtWCant.Text.StartsWith("0") && !txtWCant.Text.StartsWith("0.") && e.KeyChar != '\b' && e.KeyChar != (int)'.')
            {
                e.Handled = true;
            }
        }
    }
}
