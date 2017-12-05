using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WhatDayIsIt
{
    
    public partial class Form1 : Form
    {
        public string DzienTygodniaZDaty(int rok, int miesiac, int dzien)
        {
            DateTime dt = new DateTime(rok, miesiac, dzien);

            return dt.ToString("dddd");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = DzienTygodniaZDaty(Convert.ToInt16(textBox3.Text), Convert.ToInt16(textBox2.Text), Convert.ToInt16(textBox1.Text));
            }
            catch (Exception error)
            {
                textBox4.Text = error.Message;
            
            }
          

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
