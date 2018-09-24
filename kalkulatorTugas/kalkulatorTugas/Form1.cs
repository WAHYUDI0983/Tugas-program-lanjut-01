using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulatorTugas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int penambahan(int angka1, int angka2)
        {
            return angka1 + angka2;
        }
        public int pengurangan(int angka1, int angka2)
        {
            return angka1 - angka2;
        }
        public int perkalian(int angka1, int angka2)
        {
            return angka1 * angka2;
        }
        public int pembagian(int angka1, int angka2)
        {
            return angka1 / angka2;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int angka1 = Convert.ToInt32(textBox1.Text);
            int angka2 = Convert.ToInt32(textBox2.Text);

            if (comboBox1.Text == "Penambahan")
            {
                textBox3.Text = penambahan(angka1, angka2).ToString();
            }
            else if (comboBox1.Text == "Pengurangan")
            {
                textBox3.Text = pengurangan(angka1, angka2).ToString();
            }
            else if (comboBox1.Text == "Perkalian")
            {
                textBox3.Text = perkalian(angka1, angka2).ToString();
            }
            else if (comboBox1.Text == "Pembagian")
            {
                textBox3.Text = pembagian(angka1, angka2).ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
