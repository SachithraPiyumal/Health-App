using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HealthApp
{
    public partial class OptionForm : Form
    {
        //creating variables for constructor
        public string name;
        public int age;
        public double weight;
        public double height;
        public char gender;
        public string activity;
        public double bmiValue;
        public double bmr;
        public double caloriValue;

        public OptionForm()
        {
            InitializeComponent();
        }
        public OptionForm(string name,int age,double weight,double height,char gender,string activity)
        {
            InitializeComponent();
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.height = height;
            this.gender = gender;
            this.activity = activity;
        }

        private void btnBmiOption_Click(object sender, EventArgs e)
        {
            // hiding this form 
            this.Hide();
            // calculating BMI value
            bmiValue = Math.Round((weight / (height * height)),1);
            //open new form(BMI Result Form)
            BMIResultForm bmiResultForm = new BMIResultForm(bmiValue,name,age,weight,height);
            bmiResultForm.Show();
        }

        private void btnCaloriOption_Click(object sender, EventArgs e)
        {

            if (gender == 'f')
            {
                bmr = 655 + (9.6 * weight) + (1.8 * height * 100) - (4.7 * age);
            }
            else if (gender == 'm')
            {
                bmr = 66 + (13.7 * weight) + (5 * height * 100) - (6.7 * age);

            }
            // finding final calories value
            switch (activity)
            {
                case "1":
                    caloriValue = bmr * 1.2;
                    break;
                case "2":
                    caloriValue = bmr * 1.375;
                    break;
                case "3":
                    caloriValue = bmr * 1.55;
                    break;
                case "4":
                    caloriValue = bmr * 1.725;
                    break;
                case "5":
                    caloriValue = bmr * 1.9;
                    break;
            }
            this.Hide();
            CaloriesResultForm caloriesResultForm = new CaloriesResultForm(caloriValue,name,age,weight,height);
            caloriesResultForm.Show();
        }

        private void btnChangeDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            DetailsForm detailsForm = new DetailsForm();
            detailsForm.Show();
        }
    }
}
