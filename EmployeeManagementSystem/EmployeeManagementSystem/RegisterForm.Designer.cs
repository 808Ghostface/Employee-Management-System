namespace EmployeeManagementSystem
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Manager_btn = new System.Windows.Forms.Button();
            this.Employee_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you registering a manager or employee account?";
            // 
            // Manager_btn
            // 
            this.Manager_btn.Location = new System.Drawing.Point(272, 156);
            this.Manager_btn.Name = "Manager_btn";
            this.Manager_btn.Size = new System.Drawing.Size(161, 56);
            this.Manager_btn.TabIndex = 1;
            this.Manager_btn.Text = "Manager";
            this.Manager_btn.UseVisualStyleBackColor = true;
            this.Manager_btn.Click += new System.EventHandler(this.Manager_btn_Click);
            // 
            // Employee_btn
            // 
            this.Employee_btn.Location = new System.Drawing.Point(272, 229);
            this.Employee_btn.Name = "Employee_btn";
            this.Employee_btn.Size = new System.Drawing.Size(160, 60);
            this.Employee_btn.TabIndex = 2;
            this.Employee_btn.Text = "Employee";
            this.Employee_btn.UseVisualStyleBackColor = true;
            this.Employee_btn.Click += new System.EventHandler(this.Employee_btn_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 497);
            this.Controls.Add(this.Employee_btn);
            this.Controls.Add(this.Manager_btn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F);
            this.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Manager_btn;
        private System.Windows.Forms.Button Employee_btn;
    }
}