﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "BMI And Calorie Calculator" ;
            
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            DetailsForm detailsForm = new DetailsForm();
            detailsForm.Show();
        }

        private void btnContinue_MouseHover(object sender, EventArgs e)
        {
            btnContinue.Text = "Go";
        }

        private void btnContinue_MouseLeave(object sender, EventArgs e)
        {
            btnContinue.Text = "Continue";
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
