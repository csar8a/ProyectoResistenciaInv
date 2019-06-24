using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_calculo_fisica
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

        public void button1_Click(object sender, EventArgs e)
        { 
            
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            double d1 = double.Parse(txtdis1.Text);
            double d2 = double.Parse(txtdis2.Text);
            double d3 = double.Parse(txtdis3.Text);
            double d4 = double.Parse(txtdis4.Text);
            double d5 = double.Parse(txtdis5.Text);

            double f1 = double.Parse(txtf1.Text);
            double f2 = double.Parse(txtf2.Text);
            double f3 = double.Parse(txtf3.Text);
            double f4 = double.Parse(txtf4.Text);

            double op1 = d1 * f1;
            double op2 = (d1+d2) * f2;
            double op3 = (d1+d2+d3) * f3;
            double op4 = (d1+d2+d3+d4) * f4;
            double opf1 = op1 + op2 + op3 + op4;



            double By = opf1 / (d1 + d2 + d3 + d4+ d5);
            txtby.Text = By.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double By = double.Parse(txtby.Text);
            double f1 = double.Parse(txtf1.Text);
            double f2 = double.Parse(txtf2.Text);
            double f3 = double.Parse(txtf3.Text);
            double f4 = double.Parse(txtf4.Text);


            double sf = f1 + f2 + f3 + f4;
            double Ay = sf-By;
            txtay.Text = Ay.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //extraer
            double Ay = double.Parse(txtay.Text);

            double By = double.Parse(txtby.Text);
            double sf = By / 0.5;
            txttbc.Text = sf.ToString();
            double cos30 = Math.Pow(3,0.5)/2;
            double cal1 = sf *cos30;
            double cal2 = -(sf * cos30);
            txtbx.Text = cal1.ToString();
            txtax.Text = cal2.ToString();
            raiz1.Text = "= 11√3/2  P";
            raiz2.Text = " =  -11√3/2  P";
            double Ax = double.Parse(txtax.Text);
            double calA = Math.Pow((Math.Pow(Ay,2)+Math.Pow(Ax,2)), 0.5);
            txta.Text = calA.ToString();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double A = double.Parse(txta.Text);
            double MPA = double.Parse(txtmpa.Text);
            double dia = double.Parse(txtmm.Text);
            double final = ((MPA * 2 *((3.141592654/4)* Math.Pow(dia, 2))) / A)/1000;
            txtr1.Text = final.ToString();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double A = double.Parse(txta.Text);
            double KSI = double.Parse(txtksi.Text);
            double pul = double.Parse(txtp.Text);
            double final = (KSI * 1000 * 0.5 * 3.141592654 * Math.Pow(pul, 2)) / A;
            txtr2.Text = final.ToString();
        }
    }
}
