namespace EmployeeManagementSystem
{
    partial class MainForm
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
            this.btnInfo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.lblstudentID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbAmount = new System.Windows.Forms.ComboBox();
            this.cbPoint = new System.Windows.Forms.ComboBox();
            this.lblPoint = new System.Windows.Forms.Label();
            this.lblFlame = new System.Windows.Forms.Label();
            this.lblStar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(628, 270);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(125, 23);
            this.btnInfo.TabIndex = 92;
            this.btnInfo.Text = "Refresh Information";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(137, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(778, 150);
            this.dataGridView1.TabIndex = 91;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(319, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 13);
            this.label15.TabIndex = 90;
            this.label15.Text = "ID:";
            // 
            // lblstudentID
            // 
            this.lblstudentID.AutoSize = true;
            this.lblstudentID.Location = new System.Drawing.Point(340, 63);
            this.lblstudentID.Name = "lblstudentID";
            this.lblstudentID.Size = new System.Drawing.Size(37, 13);
            this.lblstudentID.TabIndex = 89;
            this.lblstudentID.Text = "_____";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 88;
            this.label9.Text = "Postcode";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 87;
            this.label10.Text = "Email";
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(103, 196);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(181, 20);
            this.txtPostcode.TabIndex = 86;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(103, 231);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(181, 20);
            this.txtEmail.TabIndex = 85;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(840, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 84;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(322, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 23);
            this.btnAdd.TabIndex = 83;
            this.btnAdd.Text = "Add New Employees";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 82;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(209, 264);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 81;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(103, 158);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(181, 20);
            this.txtAddress.TabIndex = 80;
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(103, 124);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(181, 20);
            this.txtCourse.TabIndex = 79;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(103, 90);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(181, 20);
            this.txtLastName.TabIndex = 78;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(103, 56);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(181, 20);
            this.txtFirstName.TabIndex = 77;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 76;
            this.label11.Text = "Address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 75;
            this.label12.Text = "Role";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 74;
            this.label13.Text = "Last Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 73;
            this.label14.Text = "First Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(922, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "Points:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(71, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(225, 20);
            this.dateTimePicker1.TabIndex = 71;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(925, 425);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 70;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(32, 425);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 23);
            this.btnBack.TabIndex = 69;
            this.btnBack.Text = "Back to Login";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(736, 10);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(264, 113);
            this.txtComment.TabIndex = 68;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(759, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 67;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbAmount
            // 
            this.cbAmount.FormattingEnabled = true;
            this.cbAmount.Items.AddRange(new object[] {
            "10",
            "50",
            "100",
            "500"});
            this.cbAmount.Location = new System.Drawing.Point(839, 173);
            this.cbAmount.Name = "cbAmount";
            this.cbAmount.Size = new System.Drawing.Size(160, 21);
            this.cbAmount.TabIndex = 66;
            // 
            // cbPoint
            // 
            this.cbPoint.FormattingEnabled = true;
            this.cbPoint.Items.AddRange(new object[] {
            "Merit",
            "Disciplinary"});
            this.cbPoint.Location = new System.Drawing.Point(839, 132);
            this.cbPoint.Name = "cbPoint";
            this.cbPoint.Size = new System.Drawing.Size(160, 21);
            this.cbPoint.TabIndex = 65;
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Location = new System.Drawing.Point(963, 372);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(37, 13);
            this.lblPoint.TabIndex = 64;
            this.lblPoint.Text = "_____";
            // 
            // lblFlame
            // 
            this.lblFlame.AutoSize = true;
            this.lblFlame.Location = new System.Drawing.Point(962, 342);
            this.lblFlame.Name = "lblFlame";
            this.lblFlame.Size = new System.Drawing.Size(37, 13);
            this.lblFlame.TabIndex = 63;
            this.lblFlame.Text = "_____";
            // 
            // lblStar
            // 
            this.lblStar.AutoSize = true;
            this.lblStar.Location = new System.Drawing.Point(962, 311);
            this.lblStar.Name = "lblStar";
            this.lblStar.Size = new System.Drawing.Size(37, 13);
            this.lblStar.TabIndex = 62;
            this.lblStar.Text = "_____";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(921, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Flame:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(921, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Star:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(671, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Comments:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(735, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Point Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(735, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Point Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Date:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 485);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblstudentID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbAmount);
            this.Controls.Add(this.cbPoint);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.lblFlame);
            this.Controls.Add(this.lblStar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblstudentID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbAmount;
        private System.Windows.Forms.ComboBox cbPoint;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Label lblFlame;
        private System.Windows.Forms.Label lblStar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}