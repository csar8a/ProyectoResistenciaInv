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

        public void button2_Click(object sender, EventArgs e)
        {
            double d1 = double.Parse(txtdiametro1.Text);
            double d2 = double.Parse(txtdiametro2.Text);
            double d3 = double.Parse(txtdiametro3.Text);

            double JAB = (3.1426 / 2) * Math.Pow(d1 / 2000, 4);
            txtJAB.Text = JAB.ToString();


            double JBC = (3.1426 / 2) * Math.Pow(d2 / 2000, 4);
            txtJBC.Text = JBC.ToString();


            double JCD = (3.1426 / 2) * (Math.Pow((d2 / 2000), 4) - Math.Pow((d3 / 2000), 4));
            txtJCD.Text = JCD.ToString();





            double ta = double.Parse(txtta.Text);
            double tb = double.Parse(txttb.Text);
            double Lab = double.Parse(txtlab.Text);
            double Lbc = double.Parse(txtlbc.Text);
            double Lcd = double.Parse(txtlcd.Text);
            double Gab = double.Parse(txtgab.Text);
            double Gbd = double.Parse(txtgbd.Text);

            double p = JAB * (Gab * (Math.Pow(10, 9)));
          

            double p2 = JBC * (Gbd * (Math.Pow(10, 9)));
           


            double p3 = JCD * (Gbd * (Math.Pow(10, 9)));
           
            double TB = tb * 1000;
            double LAB = Lab / 1000;
            double LBC = Lbc / 1000;
            double LCD = Lcd / 1000;
           
         
            double resultado1 = (ta * LAB) / p;
           
            double resultado2 = ((ta+TB) * LBC) / p2;
           
            double resultado3 = ((ta + TB) * LCD) / p3;
          

            double resultado_final=resultado1 + resultado2 + resultado3;

            txttorsion.Text = Math.Round(resultado_final, 3).ToString();




            double convertir = resultado_final*(180/3.1426);
            txtconvertir.Text = Math.Round(convertir, 3).ToString();









           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double d1 = double.Parse(txtdiametro1.Text);
            double d2 = double.Parse(txtdiametro2.Text);
            double d3 = double.Parse(txtdiametro3.Text);

            double JAB = (3.1426 / 2) * Math.Pow(d1 / 2000, 4);
            txtJAB.Text = JAB.ToString();


            double JBC = (3.1426 / 2) * Math.Pow(d2 / 2000, 4);
            txtJBC.Text = JBC.ToString();


            double JCD = (3.1426 / 2) * (Math.Pow((d2 / 2000), 4) - Math.Pow((d3 / 2000), 4));
            txtJCD.Text = JCD.ToString();


            double p = JAB * (27*(Math.Pow(10, 9)));
          
        }
    }
}
