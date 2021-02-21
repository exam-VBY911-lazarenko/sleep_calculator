using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp26


{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Добавим часы в комбобокс - от 1 до 24
            for (int i = 1; i < 24; i++)
            {
                comboBox1.Items.Add(i);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            ////Считаем ответ по формуле

            ////заносим ответ в текстбокс

            double d = 0;
            double xo = 0;
            double rez = 0;
            d = ((Convert.ToDouble(textBox1.Text)) * 60) + (Convert.ToDouble(textBox3.Text));
            xo = (Convert.ToDouble(comboBox1.Text) * 60);


            rez = d - xo;
            if (rez < 0)
            {
                rez += 1440;
            }
            if (rez > 1440)
            {
                rez -= 1440;
            }
            int q = 0;
            q = (int)rez / 60;
            d = rez % 60;

            textBox2.Text = $"{q}:{d}";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}