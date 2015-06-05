using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tachenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tshüss");
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("");
            textBox2.Text = ("");
            textBox3.Text = ("");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
          double zahl1 = 0;
          double zahl2 = 0;

          try
          {
              zahl1 = Convert.ToDouble(textBox1.Text);
              zahl2 = Convert.ToDouble(textBox2.Text);
          }
          catch
          {
                    MessageBox.Show("Die eingegebene Zahl ist zu groß! Unter 350 Stellen bitte!");
          }
          
            if (radioButton1.Checked == true)
            {
                double erg = zahl1 + zahl2;
                textBox3.Text = Convert.ToString(erg);
            }
            else if (radioButton2.Checked == true)
            {
                double erg = zahl1 - zahl2;
                textBox3.Text = Convert.ToString(erg);
            }
            else if (radioButton3.Checked == true)
            {
                double erg = zahl1 * zahl2;
                textBox3.Text = Convert.ToString(erg);
            }
            else if (radioButton4.Checked == true)
            {
                double erg = zahl1 / zahl2;
                textBox3.Text = Convert.ToString(erg);
            }
            

        }
    }
}
