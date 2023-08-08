using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HealthApp
{
    public partial class CaloriesResultForm : Form
    {
        public double caloriValue;
        public string name;
        public int age;
        public double weight;
        public double height;

        public CaloriesResultForm()
        {
            InitializeComponent();
        }
        public CaloriesResultForm(double caloriValue, string name, int age, double weight, double height)
        {
            InitializeComponent();

            this.caloriValue = Math.Round(caloriValue,2);
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.height = height;
        }

        private void CaloriesResultForm_Load(object sender, EventArgs e)
        {
            lblName.Text = name;
            txtAge.Text = Convert.ToString(age);
            txtWeight.Text = Convert.ToString(weight);
            txtHeight.Text = Convert.ToString(height);
            txtCalorieReq.Text = Convert.ToString(caloriValue);
            

        }

        private void btnChangeDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            DetailsForm detailsForm = new DetailsForm();
            detailsForm.Show();
        }
    }
}
