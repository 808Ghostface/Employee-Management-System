namespace EmployeeManagementSystem
{
    partial class Form1
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
            this.Signlbl = new System.Windows.Forms.Label();
            this.Loglbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.Enter_btn = new System.Windows.Forms.Button();
            this.Register_btn = new System.Windows.Forms.Button();
            this.userWarning = new System.Windows.Forms.Label();
            this.passWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Signlbl
            // 
            this.Signlbl.AutoSize = true;
            this.Signlbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signlbl.Location = new System.Drawing.Point(332, 38);
            this.Signlbl.Name = "Signlbl";
            this.Signlbl.Size = new System.Drawing.Size(88, 39);
            this.Signlbl.TabIndex = 0;
            this.Signlbl.Text = "Sign In";
            // 
            // Loglbl
            // 
            this.Loglbl.AutoSize = true;
            this.Loglbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loglbl.Location = new System.Drawing.Point(75, 116);
            this.Loglbl.Name = "Loglbl";
            this.Loglbl.Size = new System.Drawing.Size(76, 23);
            this.Loglbl.TabIndex = 1;
            this.Loglbl.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.label2.Location = new System.Drawing.Point(75, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(165, 118);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(360, 20);
            this.txtUser.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(165, 199);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(360, 20);
            this.txtPass.TabIndex = 4;
            // 
            // Enter_btn
            // 
            this.Enter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Enter_btn.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.Enter_btn.Location = new System.Drawing.Point(258, 257);
            this.Enter_btn.Name = "Enter_btn";
            this.Enter_btn.Size = new System.Drawing.Size(83, 33);
            this.Enter_btn.TabIndex = 5;
            this.Enter_btn.Text = "Enter";
            this.Enter_btn.UseVisualStyleBackColor = true;
            this.Enter_btn.Click += new System.EventHandler(this.Enter_btn_Click);
            // 
            // Register_btn
            // 
            this.Register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Register_btn.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.Register_btn.Location = new System.Drawing.Point(448, 257);
            this.Register_btn.Name = "Register_btn";
            this.Register_btn.Size = new System.Drawing.Size(77, 32);
            this.Register_btn.TabIndex = 6;
            this.Register_btn.Text = "Register";
            this.Register_btn.UseVisualStyleBackColor = true;
            this.Register_btn.Click += new System.EventHandler(this.Register_btn_Click);
            // 
            // userWarning
            // 
            this.userWarning.AutoSize = true;
            this.userWarning.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userWarning.ForeColor = System.Drawing.Color.Maroon;
            this.userWarning.Location = new System.Drawing.Point(162, 141);
            this.userWarning.Name = "userWarning";
            this.userWarning.Size = new System.Drawing.Size(31, 16);
            this.userWarning.TabIndex = 7;
            this.userWarning.Text = "label1";
            this.userWarning.Visible = false;
            // 
            // passWarning
            // 
            this.passWarning.AutoSize = true;
            this.passWarning.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F);
            this.passWarning.ForeColor = System.Drawing.Color.Maroon;
            this.passWarning.Location = new System.Drawing.Point(162, 222);
            this.passWarning.Name = "passWarning";
            this.passWarning.Size = new System.Drawing.Size(33, 16);
            this.passWarning.TabIndex = 8;
            this.passWarning.Text = "label3";
            this.passWarning.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.passWarning);
            this.Controls.Add(this.userWarning);
            this.Controls.Add(this.Register_btn);
            this.Controls.Add(this.Enter_btn);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Loglbl);
            this.Controls.Add(this.Signlbl);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Signlbl;
        private System.Windows.Forms.Label Loglbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button Enter_btn;
        private System.Windows.Forms.Button Register_btn;
        private System.Windows.Forms.Label userWarning;
        private System.Windows.Forms.Label passWarning;
    }
}

