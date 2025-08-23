using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // TextBoxes
        private TextBox txtStudentName;
        private TextBox txtStudentId;
        private TextBox txtAddress;

        // Radio Buttons
        private RadioButton rbMale;
        private RadioButton rbFemale;

        // Combo Boxes
        private ComboBox cmbDay;
        private ComboBox cmbMonth;
        private ComboBox cmbYear;

        // Button
        private Button btnDisplay;

        // Labels
        private Label lblStudentName;
        private Label lblStudentId;
        private Label lblGender;
        private Label lblDateOfBirth;
        private Label lblAddress;
        private Label lblOutput;

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
            lblStudentName = new Label();
            txtStudentName = new TextBox();
            lblStudentId = new Label();
            txtStudentId = new TextBox();
            lblGender = new Label();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            lblDateOfBirth = new Label();
            cmbDay = new ComboBox();
            cmbMonth = new ComboBox();
            cmbYear = new ComboBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            btnDisplay = new Button();
            lblOutput = new Label();
            SuspendLayout();
            // 
            // lblStudentName
            // 
            lblStudentName.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblStudentName.Location = new Point(30, 9);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(120, 20);
            lblStudentName.TabIndex = 0;
            lblStudentName.Text = "Student Name:";
            // 
            // txtStudentName
            // 
            txtStudentName.Font = new Font("Arial", 12F);
            txtStudentName.Location = new Point(30, 32);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(200, 30);
            txtStudentName.TabIndex = 1;
            // 
            // lblStudentId
            // 
            lblStudentId.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblStudentId.Location = new Point(30, 78);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(120, 20);
            lblStudentId.TabIndex = 2;
            lblStudentId.Text = "Student ID:";
            // 
            // txtStudentId
            // 
            txtStudentId.Font = new Font("Arial", 12F);
            txtStudentId.Location = new Point(30, 101);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(200, 30);
            txtStudentId.TabIndex = 3;
            // 
            // lblGender
            // 
            lblGender.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblGender.Location = new Point(30, 137);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(88, 20);
            lblGender.TabIndex = 4;
            lblGender.Text = "Gender:";
            // 
            // rbMale
            // 
            rbMale.Checked = true;
            rbMale.Font = new Font("Arial", 12F);
            rbMale.Location = new Point(124, 137);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(80, 25);
            rbMale.TabIndex = 5;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            // 
            // rbFemale
            // 
            rbFemale.Font = new Font("Arial", 12F);
            rbFemale.Location = new Point(210, 137);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(96, 25);
            rbFemale.TabIndex = 6;
            rbFemale.Text = "Female";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblDateOfBirth.Location = new Point(30, 165);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(257, 20);
            lblDateOfBirth.TabIndex = 7;
            lblDateOfBirth.Text = "Date of Birth (DD/MM/YY):";
            // 
            // cmbDay
            // 
            cmbDay.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDay.Font = new Font("Arial", 12F);
            cmbDay.Location = new Point(30, 197);
            cmbDay.Name = "cmbDay";
            cmbDay.Size = new Size(60, 31);
            cmbDay.TabIndex = 8;
            // 
            // cmbMonth
            // 
            cmbMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMonth.Font = new Font("Arial", 12F);
            cmbMonth.Location = new Point(96, 197);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(80, 31);
            cmbMonth.TabIndex = 9;
            // 
            // cmbYear
            // 
            cmbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYear.Font = new Font("Arial", 12F);
            cmbYear.Location = new Point(182, 197);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(80, 31);
            cmbYear.TabIndex = 10;
            // 
            // lblAddress
            // 
            lblAddress.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblAddress.Location = new Point(30, 237);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(95, 20);
            lblAddress.TabIndex = 11;
            lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Arial", 12F);
            txtAddress.Location = new Point(116, 234);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(308, 30);
            txtAddress.TabIndex = 12;
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = Color.Crimson;
            btnDisplay.FlatStyle = FlatStyle.Flat;
            btnDisplay.Font = new Font("Arial", 12F);
            btnDisplay.ForeColor = Color.White;
            btnDisplay.Location = new Point(30, 282);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(232, 40);
            btnDisplay.TabIndex = 13;
            btnDisplay.Text = "Register Student";
            btnDisplay.UseVisualStyleBackColor = false;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // lblOutput
            // 
            lblOutput.BackColor = Color.LightGray;
            lblOutput.BorderStyle = BorderStyle.FixedSingle;
            lblOutput.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblOutput.Location = new Point(12, 337);
            lblOutput.Name = "lblOutput";
            lblOutput.Padding = new Padding(10);
            lblOutput.Size = new Size(476, 154);
            lblOutput.TabIndex = 14;
            // 
            // Form1
            // 
            BackColor = Color.White;
            ClientSize = new Size(500, 500);
            Controls.Add(lblStudentName);
            Controls.Add(txtStudentName);
            Controls.Add(lblStudentId);
            Controls.Add(txtStudentId);
            Controls.Add(lblGender);
            Controls.Add(rbMale);
            Controls.Add(rbFemale);
            Controls.Add(lblDateOfBirth);
            Controls.Add(cmbDay);
            Controls.Add(cmbMonth);
            Controls.Add(cmbYear);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(btnDisplay);
            Controls.Add(lblOutput);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Registration Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
