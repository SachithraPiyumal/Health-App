using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HealthApp
{
    public partial class BMIResultForm : Form
    {
        //creating variables for constructor
       
        public double bmiValue;
        public string name;
        public int age;
        public double weight;
        public double height;
        public string bmiCategory;

        public BMIResultForm()
        {
            InitializeComponent();
        }
        public BMIResultForm(double bmiValue,string name,int age,double weight,double height)
        {
            InitializeComponent();

            this.bmiValue = bmiValue;
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.height = height;
            
        }

        private void BMIResultForm_Load(object sender, EventArgs e)
        {

            //Determine BMI Category
            if (bmiValue >= 30)
            {
                bmiCategory = "Obesity";
            }
            else if (bmiValue >= 25)
            {
                bmiCategory = "Over Weight";
            }
            else if (bmiValue > 18.5)
            {
                bmiCategory = "Normal Weight";
            }
            else
            {
                bmiCategory = "Under Weight";
            }

            //Adding values to textboxes
            lblBmiValue.Text = name;
            txtAge.Text = age.ToString();
            txtWeight.Text = Convert.ToString(weight);
            txtHeight.Text = Convert.ToString(height);
            txtBmi.Text = Convert.ToString(bmiValue);
            txtBmCategory.Text = bmiCategory;


        }

        private void btnChangeDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            DetailsForm detailsForm = new DetailsForm();
            detailsForm.Show();
        }
    }
}
