
namespace HealthApp
{
    partial class DetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailsForm));
            this.lblName = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbActivity = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblNameError = new System.Windows.Forms.Label();
            this.lblDateError = new System.Windows.Forms.Label();
            this.lblHeightError = new System.Windows.Forms.Label();
            this.lblGenderError = new System.Windows.Forms.Label();
            this.lblActivityError = new System.Windows.Forms.Label();
            this.lblWeightError = new System.Windows.Forms.Label();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.grbGender = new System.Windows.Forms.GroupBox();
            this.lblActivityLevel = new System.Windows.Forms.Label();
            this.grbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(85, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 24);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name*";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDOB.Location = new System.Drawing.Point(85, 108);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(120, 24);
            this.lblDOB.TabIndex = 0;
            this.lblDOB.Text = "Date Of Birth*";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWeight.Location = new System.Drawing.Point(85, 185);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(110, 24);
            this.lblWeight.TabIndex = 0;
            this.lblWeight.Text = "Weight (Kg)*";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeight.Location = new System.Drawing.Point(85, 257);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(102, 24);
            this.lblHeight.TabIndex = 0;
            this.lblHeight.Text = "Height (m)*";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(2)))), ((int)(((byte)(33)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(340, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(279, 29);
            this.txtName.TabIndex = 1;
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(2)))), ((int)(((byte)(33)))));
            this.txtWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWeight.ForeColor = System.Drawing.Color.White;
            this.txtWeight.Location = new System.Drawing.Point(340, 180);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(279, 29);
            this.txtWeight.TabIndex = 1;
            // 
            // txtHeight
            // 
            this.txtHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(2)))), ((int)(((byte)(33)))));
            this.txtHeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHeight.ForeColor = System.Drawing.Color.White;
            this.txtHeight.Location = new System.Drawing.Point(340, 252);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(279, 29);
            this.txtHeight.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(2)))), ((int)(((byte)(33)))));
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(2)))), ((int)(((byte)(33)))));
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.Location = new System.Drawing.Point(340, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(279, 23);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // cmbActivity
            // 
            this.cmbActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(2)))), ((int)(((byte)(33)))));
            this.cmbActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbActivity.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbActivity.ForeColor = System.Drawing.Color.White;
            this.cmbActivity.FormattingEnabled = true;
            this.cmbActivity.Location = new System.Drawing.Point(340, 464);
            this.cmbActivity.Name = "cmbActivity";
            this.cmbActivity.Size = new System.Drawing.Size(279, 28);
            this.cmbActivity.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(73, 553);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 47);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(509, 553);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(110, 47);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit Form";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameError.ForeColor = System.Drawing.Color.Maroon;
            this.lblNameError.Location = new System.Drawing.Point(340, 69);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(52, 21);
            this.lblNameError.TabIndex = 6;
            this.lblNameError.Text = "label1";
            this.lblNameError.Visible = false;
            // 
            // lblDateError
            // 
            this.lblDateError.AutoSize = true;
            this.lblDateError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateError.ForeColor = System.Drawing.Color.Maroon;
            this.lblDateError.Location = new System.Drawing.Point(340, 138);
            this.lblDateError.Name = "lblDateError";
            this.lblDateError.Size = new System.Drawing.Size(52, 21);
            this.lblDateError.TabIndex = 6;
            this.lblDateError.Text = "label1";
            this.lblDateError.Visible = false;
            // 
            // lblHeightError
            // 
            this.lblHeightError.AutoSize = true;
            this.lblHeightError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeightError.ForeColor = System.Drawing.Color.Maroon;
            this.lblHeightError.Location = new System.Drawing.Point(340, 284);
            this.lblHeightError.Name = "lblHeightError";
            this.lblHeightError.Size = new System.Drawing.Size(52, 21);
            this.lblHeightError.TabIndex = 6;
            this.lblHeightError.Text = "label1";
            this.lblHeightError.Visible = false;
            // 
            // lblGenderError
            // 
            this.lblGenderError.AutoSize = true;
            this.lblGenderError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGenderError.ForeColor = System.Drawing.Color.Maroon;
            this.lblGenderError.Location = new System.Drawing.Point(340, 428);
            this.lblGenderError.Name = "lblGenderError";
            this.lblGenderError.Size = new System.Drawing.Size(52, 21);
            this.lblGenderError.TabIndex = 6;
            this.lblGenderError.Text = "label1";
            this.lblGenderError.Visible = false;
            // 
            // lblActivityError
            // 
            this.lblActivityError.AutoSize = true;
            this.lblActivityError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActivityError.ForeColor = System.Drawing.Color.Maroon;
            this.lblActivityError.Location = new System.Drawing.Point(340, 495);
            this.lblActivityError.Name = "lblActivityError";
            this.lblActivityError.Size = new System.Drawing.Size(52, 21);
            this.lblActivityError.TabIndex = 6;
            this.lblActivityError.Text = "label1";
            this.lblActivityError.Visible = false;
            // 
            // lblWeightError
            // 
            this.lblWeightError.AutoSize = true;
            this.lblWeightError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWeightError.ForeColor = System.Drawing.Color.Maroon;
            this.lblWeightError.Location = new System.Drawing.Point(340, 212);
            this.lblWeightError.Name = "lblWeightError";
            this.lblWeightError.Size = new System.Drawing.Size(52, 21);
            this.lblWeightError.TabIndex = 6;
            this.lblWeightError.Text = "label1";
            this.lblWeightError.Visible = false;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbMale.Location = new System.Drawing.Point(67, 22);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(62, 25);
            this.rdbMale.TabIndex = 0;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbFemale.Location = new System.Drawing.Point(67, 53);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(78, 25);
            this.rdbFemale.TabIndex = 0;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // grbGender
            // 
            this.grbGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(2)))), ((int)(((byte)(33)))));
            this.grbGender.Controls.Add(this.rdbFemale);
            this.grbGender.Controls.Add(this.rdbMale);
            this.grbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbGender.ForeColor = System.Drawing.Color.White;
            this.grbGender.Location = new System.Drawing.Point(340, 325);
            this.grbGender.Name = "grbGender";
            this.grbGender.Size = new System.Drawing.Size(279, 100);
            this.grbGender.TabIndex = 3;
            this.grbGender.TabStop = false;
            this.grbGender.Text = "Gender";
            // 
            // lblActivityLevel
            // 
            this.lblActivityLevel.AutoSize = true;
            this.lblActivityLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblActivityLevel.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActivityLevel.Location = new System.Drawing.Point(73, 464);
            this.lblActivityLevel.Name = "lblActivityLevel";
            this.lblActivityLevel.Size = new System.Drawing.Size(114, 24);
            this.lblActivityLevel.TabIndex = 7;
            this.lblActivityLevel.Text = "Activity Level";
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(2)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(706, 630);
            this.Controls.Add(this.lblActivityLevel);
            this.Controls.Add(this.lblActivityError);
            this.Controls.Add(this.lblGenderError);
            this.Controls.Add(this.lblWeightError);
            this.Controls.Add(this.lblHeightError);
            this.Controls.Add(this.lblDateError);
            this.Controls.Add(this.lblNameError);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbActivity);
            this.Controls.Add(this.grbGender);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblName);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.DetailsForm_Load);
            this.grbGender.ResumeLayout(false);
            this.grbGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbActivity;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.Label lblDateError;
        private System.Windows.Forms.Label lblHeightError;
        private System.Windows.Forms.Label lblGenderError;
        private System.Windows.Forms.Label lblActivityError;
        private System.Windows.Forms.Label lblWeightError;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.GroupBox grbGender;
        private System.Windows.Forms.Label lblActivityLevel;
    }
}