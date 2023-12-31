﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButtonUrgent.Click += RadioButton_Enter; 
            radioButtonOrdinary.Click += RadioButton_Enter;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
              
        }
        //BE CAREFUL, MY CODE CALCULATES ALSO SPACES

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //bool esUrgente = checkBox1.Checked; //this is for the first code. 
            bool esUrgente = radioButtonUrgent.Checked;
            int numPalabras = 0;
            double coste;

            string textoTelegrama = txtText.Text;

            numPalabras = textoTelegrama.Split(' ').Length;

            // Calculate the cost
            if (!esUrgente)
            {
                coste = Math.Min(10, numPalabras) * 2.5 + Math.Max(0, numPalabras - 10) * 0.25;//be careful here! 1/2 of the cost
            }
            else
            {
                coste = Math.Min(10, numPalabras) * 5 + Math.Max(0, numPalabras - 10) * 0.375;//same here! 
            }

            txtCost.Text = coste.ToString("0.00") + " euros";
        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void RadioButton_Enter(object sender, EventArgs e)
        {
            radioButtonUrgent.Checked = (sender == radioButtonUrgent);
            radioButtonOrdinary.Checked = (sender == radioButtonOrdinary);
        }
    }
    }

