
namespace HealthApp
{
    partial class OptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionForm));
            this.btnBmiOption = new System.Windows.Forms.Button();
            this.btnCaloriOption = new System.Windows.Forms.Button();
            this.lblOption = new System.Windows.Forms.Label();
            this.btnChangeDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBmiOption
            // 
            this.btnBmiOption.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnBmiOption.FlatAppearance.BorderSize = 5;
            this.btnBmiOption.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBmiOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBmiOption.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBmiOption.ForeColor = System.Drawing.Color.White;
            this.btnBmiOption.Location = new System.Drawing.Point(116, 115);
            this.btnBmiOption.Name = "btnBmiOption";
            this.btnBmiOption.Size = new System.Drawing.Size(169, 146);
            this.btnBmiOption.TabIndex = 0;
            this.btnBmiOption.Text = "BMI";
            this.btnBmiOption.UseVisualStyleBackColor = true;
            this.btnBmiOption.Click += new System.EventHandler(this.btnBmiOption_Click);
            // 
            // btnCaloriOption
            // 
            this.btnCaloriOption.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnCaloriOption.FlatAppearance.BorderSize = 5;
            this.btnCaloriOption.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCaloriOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaloriOption.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCaloriOption.ForeColor = System.Drawing.Color.White;
            this.btnCaloriOption.Location = new System.Drawing.Point(399, 115);
            this.btnCaloriOption.Name = "btnCaloriOption";
            this.btnCaloriOption.Size = new System.Drawing.Size(180, 146);
            this.btnCaloriOption.TabIndex = 0;
            this.btnCaloriOption.Text = "Calorie Intake";
            this.btnCaloriOption.UseVisualStyleBackColor = true;
            this.btnCaloriOption.Click += new System.EventHandler(this.btnCaloriOption_Click);
            // 
            // lblOption
            // 
            this.lblOption.AutoSize = true;
            this.lblOption.Font = new System.Drawing.Font("Footlight MT Light", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOption.ForeColor = System.Drawing.Color.White;
            this.lblOption.Location = new System.Drawing.Point(70, 39);
            this.lblOption.Name = "lblOption";
            this.lblOption.Size = new System.Drawing.Size(590, 33);
            this.lblOption.TabIndex = 1;
            this.lblOption.Text = "which is you want to know about your body?";
            // 
            // btnChangeDetails
            // 
            this.btnChangeDetails.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnChangeDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnChangeDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangeDetails.ForeColor = System.Drawing.Color.White;
            this.btnChangeDetails.Location = new System.Drawing.Point(282, 302);
            this.btnChangeDetails.Name = "btnChangeDetails";
            this.btnChangeDetails.Size = new System.Drawing.Size(125, 48);
            this.btnChangeDetails.TabIndex = 2;
            this.btnChangeDetails.Text = "Change Details";
            this.btnChangeDetails.UseVisualStyleBackColor = true;
            this.btnChangeDetails.Click += new System.EventHandler(this.btnChangeDetails_Click);
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(2)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(709, 373);
            this.Controls.Add(this.btnChangeDetails);
            this.Controls.Add(this.lblOption);
            this.Controls.Add(this.btnCaloriOption);
            this.Controls.Add(this.btnBmiOption);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OptionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBmiOption;
        private System.Windows.Forms.Button btnCaloriOption;
        private System.Windows.Forms.Label lblOption;
        private System.Windows.Forms.Button btnChangeDetails;
    }
}