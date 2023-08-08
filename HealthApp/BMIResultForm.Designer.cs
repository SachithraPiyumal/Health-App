
namespace HealthApp
{
    partial class BMIResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMIResultForm));
            this.lblBmiValue = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblBmi = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtBmi = new System.Windows.Forms.TextBox();
            this.txtBmCategory = new System.Windows.Forms.TextBox();
            this.lblBmiCategory = new System.Windows.Forms.Label();
            this.btnChangeDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBmiValue
            // 
            this.lblBmiValue.AutoSize = true;
            this.lblBmiValue.Font = new System.Drawing.Font("Source Sans Pro", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBmiValue.ForeColor = System.Drawing.Color.White;
            this.lblBmiValue.Location = new System.Drawing.Point(338, 25);
            this.lblBmiValue.Name = "lblBmiValue";
            this.lblBmiValue.Size = new System.Drawing.Size(108, 44);
            this.lblBmiValue.TabIndex = 0;
            this.lblBmiValue.Text = "label1";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAge.ForeColor = System.Drawing.Color.White;
            this.lblAge.Location = new System.Drawing.Point(159, 109);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(77, 21);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Your Age ";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWeight.ForeColor = System.Drawing.Color.White;
            this.lblWeight.Location = new System.Drawing.Point(159, 167);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(126, 21);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "Your Weight (kg)";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeight.ForeColor = System.Drawing.Color.White;
            this.lblHeight.Location = new System.Drawing.Point(159, 238);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(120, 21);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "Your Height (m)";
            // 
            // lblBmi
            // 
            this.lblBmi.AutoSize = true;
            this.lblBmi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBmi.ForeColor = System.Drawing.Color.White;
            this.lblBmi.Location = new System.Drawing.Point(159, 310);
            this.lblBmi.Name = "lblBmi";
            this.lblBmi.Size = new System.Drawing.Size(115, 21);
            this.lblBmi.TabIndex = 1;
            this.lblBmi.Text = "Your BMI Value";
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(2)))), ((int)(((byte)(33)))));
            this.txtAge.Enabled = false;
            this.txtAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAge.ForeColor = System.Drawing.Color.White;
            this.txtAge.Location = new System.Drawing.Point(371, 101);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(204, 29);
            this.txtAge.TabIndex = 2;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(2)))), ((int)(((byte)(33)))));
            this.txtWeight.Enabled = false;
            this.txtWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWeight.ForeColor = System.Drawing.Color.White;
            this.txtWeight.Location = new System.Drawing.Point(371, 164);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.ReadOnly = true;
            this.txtWeight.Size = new System.Drawing.Size(204, 29);
            this.txtWeight.TabIndex = 2;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHeight
            // 
            this.txtHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(2)))), ((int)(((byte)(33)))));
            this.txtHeight.Enabled = false;
            this.txtHeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHeight.ForeColor = System.Drawing.Color.White;
            this.txtHeight.Location = new System.Drawing.Point(371, 235);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.ReadOnly = true;
            this.txtHeight.Size = new System.Drawing.Size(204, 29);
            this.txtHeight.TabIndex = 2;
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBmi
            // 
            this.txtBmi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(2)))), ((int)(((byte)(33)))));
            this.txtBmi.Enabled = false;
            this.txtBmi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBmi.ForeColor = System.Drawing.Color.White;
            this.txtBmi.Location = new System.Drawing.Point(371, 302);
            this.txtBmi.Name = "txtBmi";
            this.txtBmi.ReadOnly = true;
            this.txtBmi.Size = new System.Drawing.Size(204, 29);
            this.txtBmi.TabIndex = 2;
            this.txtBmi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBmCategory
            // 
            this.txtBmCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(2)))), ((int)(((byte)(33)))));
            this.txtBmCategory.Enabled = false;
            this.txtBmCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBmCategory.ForeColor = System.Drawing.Color.White;
            this.txtBmCategory.Location = new System.Drawing.Point(371, 369);
            this.txtBmCategory.Name = "txtBmCategory";
            this.txtBmCategory.ReadOnly = true;
            this.txtBmCategory.Size = new System.Drawing.Size(204, 29);
            this.txtBmCategory.TabIndex = 2;
            this.txtBmCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBmiCategory
            // 
            this.lblBmiCategory.AutoSize = true;
            this.lblBmiCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBmiCategory.ForeColor = System.Drawing.Color.White;
            this.lblBmiCategory.Location = new System.Drawing.Point(159, 377);
            this.lblBmiCategory.Name = "lblBmiCategory";
            this.lblBmiCategory.Size = new System.Drawing.Size(140, 21);
            this.lblBmiCategory.TabIndex = 1;
            this.lblBmiCategory.Text = "Your BMI Cateogry";
            // 
            // btnChangeDetails
            // 
            this.btnChangeDetails.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnChangeDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnChangeDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangeDetails.ForeColor = System.Drawing.Color.White;
            this.btnChangeDetails.Location = new System.Drawing.Point(633, 395);
            this.btnChangeDetails.Name = "btnChangeDetails";
            this.btnChangeDetails.Size = new System.Drawing.Size(134, 43);
            this.btnChangeDetails.TabIndex = 3;
            this.btnChangeDetails.Text = "Change Details";
            this.btnChangeDetails.UseVisualStyleBackColor = true;
            this.btnChangeDetails.Click += new System.EventHandler(this.btnChangeDetails_Click);
            // 
            // BMIResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(2)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChangeDetails);
            this.Controls.Add(this.txtBmCategory);
            this.Controls.Add(this.txtBmi);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblBmiCategory);
            this.Controls.Add(this.lblBmi);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblBmiValue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BMIResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMIResultForm";
            this.Load += new System.EventHandler(this.BMIResultForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBmiValue;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblBmi;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtBmi;
        private System.Windows.Forms.TextBox txtBmCategory;
        private System.Windows.Forms.Label lblBmiCategory;
        private System.Windows.Forms.Button btnChangeDetails;
    }
}