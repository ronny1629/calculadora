﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (cajaresultado.Text == "0")
            {
                return;
            }
            else
            {
                cajaresultado.Text += "0";
            }
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            cajaresultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            cajaresultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            cajaresultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            cajaresultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            cajaresultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            cajaresultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            cajaresultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            cajaresultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            cajaresultado.Text += "9";
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            cajaresultado.Text += "x";
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            cajaresultado.Text += "+";
        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            cajaresultado.Text += "-";
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            cajaresultado.Text += "÷";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            cajaresultado.Text += ".";
       }
    }
}
