using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace koli_naem
{
    public partial class Form1 : Form
    {
        DateTime den1, den2;
        int dni;
        double cena, cena_pl;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cena = 0;
            if (koli.Text == "Audi A4")
            {
                cena = 40;
                pictureBox1.Image = Image.FromFile("image/audiA4.jpg");
            }
            else if (koli.Text == "Mazda 6")
            {
                cena = 35;
                pictureBox1.Image = Image.FromFile("image/mazda6.jpg");
            }
            else if (koli.Text == "VW polo 2015")
            {
                cena = 33;
                pictureBox1.Image = Image.FromFile("image/vwPolo.jpg");
            }
            else if (koli.Text == "Renault Scenic")
            {
                cena = 45;
                pictureBox1.Image = Image.FromFile("image/renault.jpg");
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            den1 = data1.Value; den2 = data2.Value;
            dni = (den2 - den1).Days;
            period.Text = dni.ToString() + " дни";
            cena_pl = dni * cena;
            if (stol.Checked) cena_pl = cena + 40;
            if (verigi.Checked) cena_pl = cena + 45;
            if (bagajnik.Checked) cena_pl = cena + 35;
            plashtane.Text = cena_pl.ToString() + " лева";
        }
    }
}
