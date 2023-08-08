using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HealthApp
{
   

    public partial class DetailsForm : Form
    {
        // creqating groble varibles for calculation part
        public string name;
        public int age;
        public double weight;
        public double height;
        public char gender;
        public string activity;
    

        public DetailsForm()
        {
            InitializeComponent();
        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {
            // Loading activity items to combobox when form loading
            string[] cmbItems = { "Sedentary (little or no exercise)", "Lightly active (exercise 1–3 days/week)", "Moderately active (exercise 3–5 days/week)", "Active (exercise 6–7 days/week)", "Very active (hard exercise 6–7 days/week)" };
            foreach (string i in cmbItems)
            {
                cmbActivity.Items.Add(i);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // calculatin age
            age = (DateTime.Today.Year) - (dateTimePicker1.Value.Year);
            //findinig gender
            if (rdbMale.Checked)
            {
                gender = 'm';
            }
            else
            {
                gender = 'f';
            }
            // Finding selected activity level
            string selectActivity = cmbActivity.Text;

            switch (selectActivity)
            {
                case "Sedentary (little or no exercise)":
                    activity = "1";
                    break;

                case "Lightly active (exercise 1–3 days/week)":
                    activity = "2";
                    break;
                case "Moderately active (exercise 3–5 days/week)":
                    activity = "3";
                    break;
                case "Active (exercise 6–7 days/week)":
                    activity = "4";
                    break;
                case "Very active (hard exercise 6–7 days/week)":
                    activity = "5";
                    break;
            }

            //checking all input are fill when clicking submit button
            if (txtName.Text.Trim() == "")
            {
                lblNameError.Text = "Please enter a name!";
                lblNameError.Visible = true;

            }
            else if (txtWeight.Text.Trim() == "")
            {
                lblWeightError.Text = "Please enter a weight(Kg)!";
                lblWeightError.Visible = true;

            }
            else if (txtHeight.Text.Trim() == "")
            {
                lblHeightError.Text = "Please enter a height(CM)!";
                lblHeightError.Visible = true;
            }
            else if (dateTimePicker1.Checked == false)
            {
                lblDateError.Text = "please enter a date!";
                lblDateError.Visible = true;
            }
            else if (rdbFemale.Checked == false & rdbMale.Checked == false)
            {
                lblGenderError.Text = "Please enter select gender!";
                lblGenderError.Visible = true;
            }
            else if (cmbActivity.SelectedIndex == -1)
            {
                lblActivityError.Text = "Please Select your activity level";
                lblActivityError.Visible = true;
            }
            else
            {
                //hiding details form
                this.Hide();

                //open option selection form
                weight = double.Parse(txtWeight.Text);
                height = double.Parse(txtHeight.Text);
                OptionForm optionForm = new OptionForm(txtName.Text,age,weight,height,gender,activity);
                optionForm.Show();
            }

            
            
           

        }

        // Clear all form inputs
        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear all text boxes
            txtName.Clear();
            txtWeight.Clear();
            txtHeight.Clear();

            //clear all radio buttons
            rdbMale.Checked = false;
            rdbFemale.Checked = false;

            //clear combobox
            cmbActivity.SelectedIndex = -1;

            //clear calender
            dateTimePicker1.Value = DateTime.Now;



        }
    }
}
