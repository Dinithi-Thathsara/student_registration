namespace Student_Registration_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            btnSubmit = new Button();
            cmbDepartment = new ComboBox();
            rbOther = new RadioButton();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            txtPhoneNumber = new TextBox();
            txtEmail = new TextBox();
            txtStudentID = new TextBox();
            txtStudentName = new TextBox();
            lblDetails = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightSeaGreen;
            textBox1.Location = new Point(-3, -1);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1147, 100);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(384, 25);
            label1.Name = "label1";
            label1.Size = new Size(462, 37);
            label1.TabIndex = 1;
            label1.Text = "Student Registration Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 56);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 2;
            label2.Text = "Student Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 126);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 3;
            label3.Text = "Student ID";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(45, 193);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 4;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(36, 259);
            label5.Name = "label5";
            label5.Size = new Size(140, 25);
            label5.TabIndex = 5;
            label5.Text = "Phone Number";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(45, 333);
            label6.Name = "label6";
            label6.Size = new Size(74, 25);
            label6.TabIndex = 6;
            label6.Text = "Gender";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(36, 394);
            label7.Name = "label7";
            label7.Size = new Size(115, 25);
            label7.TabIndex = 7;
            label7.Text = "Department";
            label7.Click += label7_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(cmbDepartment);
            panel1.Controls.Add(rbOther);
            panel1.Controls.Add(rbFemale);
            panel1.Controls.Add(rbMale);
            panel1.Controls.Add(txtPhoneNumber);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtStudentID);
            panel1.Controls.Add(txtStudentName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(33, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(703, 522);
            panel1.TabIndex = 8;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.MenuHighlight;
            btnSubmit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = SystemColors.ButtonHighlight;
            btnSubmit.Location = new Point(235, 461);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(215, 42);
            btnSubmit.TabIndex = 19;
            btnSubmit.Text = "Submit Registration";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Items.AddRange(new object[] { "Computer Science", "Engineering", "Business", "Bio Medical Science" });
            cmbDepartment.Location = new Point(214, 391);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(358, 28);
            cmbDepartment.TabIndex = 18;
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.Location = new Point(434, 324);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(67, 24);
            rbOther.TabIndex = 17;
            rbOther.TabStop = true;
            rbOther.Text = "Other";
            rbOther.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(319, 324);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(78, 24);
            rbFemale.TabIndex = 16;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Cursor = Cursors.Hand;
            rbMale.Location = new Point(214, 324);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(63, 24);
            rbMale.TabIndex = 15;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Cursor = Cursors.IBeam;
            txtPhoneNumber.Location = new Point(214, 243);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(361, 41);
            txtPhoneNumber.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Location = new Point(214, 177);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(361, 41);
            txtEmail.TabIndex = 11;
            // 
            // txtStudentID
            // 
            txtStudentID.Cursor = Cursors.IBeam;
            txtStudentID.Location = new Point(214, 110);
            txtStudentID.Multiline = true;
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(361, 41);
            txtStudentID.TabIndex = 10;
            txtStudentID.TextChanged += textBox3_TextChanged;
            // 
            // txtStudentName
            // 
            txtStudentName.BorderStyle = BorderStyle.FixedSingle;
            txtStudentName.Cursor = Cursors.IBeam;
            txtStudentName.Location = new Point(214, 40);
            txtStudentName.Multiline = true;
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(361, 41);
            txtStudentName.TabIndex = 9;
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Location = new Point(855, 186);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(188, 20);
            lblDetails.TabIndex = 9;
            lblDetails.Text = "Regidtered Student Details";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background1;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1144, 667);
            Controls.Add(lblDetails);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private TextBox txtPhoneNumber;
        private TextBox txtEmail;
        private TextBox txtStudentID;
        private TextBox txtStudentName;
        private RadioButton rbOther;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private ComboBox cmbDepartment;
        private Button btnSubmit;
        private Label lblDetails;
    }
}
