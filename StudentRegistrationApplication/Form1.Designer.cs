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
            this.SuspendLayout();

            // Window properties
            this.Text = "Student Registration Application";
            this.Size = new Size(600, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.White;

            // Student Name Label
            lblStudentName = new Label();
            lblStudentName.Text = "Student Name:";
            lblStudentName.Location = new Point(30, 30);
            lblStudentName.Size = new Size(120, 20);
            lblStudentName.Font = new Font("Arial", 12, FontStyle.Bold);
            this.Controls.Add(lblStudentName);

            // Student Name TextBox
            txtStudentName = new TextBox();
            txtStudentName.Location = new Point(160, 28);
            txtStudentName.Size = new Size(200, 25);
            txtStudentName.Font = new Font("Arial", 12);
            this.Controls.Add(txtStudentName);

            // Student ID Label
            lblStudentId = new Label();
            lblStudentId.Text = "Student ID:";
            lblStudentId.Location = new Point(30, 70);
            lblStudentId.Size = new Size(120, 20);
            lblStudentId.Font = new Font("Arial", 12, FontStyle.Bold);
            this.Controls.Add(lblStudentId);

            // Student ID TextBox
            txtStudentId = new TextBox();
            txtStudentId.Location = new Point(160, 68);
            txtStudentId.Size = new Size(200, 25);
            txtStudentId.Font = new Font("Arial", 12);
            this.Controls.Add(txtStudentId);

            // Gender Label
            lblGender = new Label();
            lblGender.Text = "Gender:";
            lblGender.Location = new Point(30, 110);
            lblGender.Size = new Size(120, 20);
            lblGender.Font = new Font("Arial", 12, FontStyle.Bold);
            this.Controls.Add(lblGender);

            // Male Radio Button
            rbMale = new RadioButton();
            rbMale.Text = "Male";
            rbMale.Location = new Point(160, 108);
            rbMale.Size = new Size(80, 25);
            rbMale.Font = new Font("Arial", 12);
            rbMale.Checked = true;
            this.Controls.Add(rbMale);

            // Female Radio Button
            rbFemale = new RadioButton();
            rbFemale.Text = "Female";
            rbFemale.Location = new Point(250, 108);
            rbFemale.Size = new Size(80, 25);
            rbFemale.Font = new Font("Arial", 12);
            this.Controls.Add(rbFemale);

            // Date of Birth Label
            lblDateOfBirth = new Label();
            lblDateOfBirth.Text = "Date of Birth:";
            lblDateOfBirth.Location = new Point(30, 150);
            lblDateOfBirth.Size = new Size(120, 20);
            lblDateOfBirth.Font = new Font("Arial", 12, FontStyle.Bold);
            this.Controls.Add(lblDateOfBirth);

            // Day ComboBox
            cmbDay = new ComboBox();
            cmbDay.Location = new Point(160, 148);
            cmbDay.Size = new Size(60, 25);
            cmbDay.Font = new Font("Arial", 12);
            cmbDay.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Controls.Add(cmbDay);

            // Month ComboBox
            cmbMonth = new ComboBox();
            cmbMonth.Location = new Point(230, 148);
            cmbMonth.Size = new Size(80, 25);
            cmbMonth.Font = new Font("Arial", 12);
            cmbMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Controls.Add(cmbMonth);

            // Year ComboBox
            cmbYear = new ComboBox();
            cmbYear.Location = new Point(320, 148);
            cmbYear.Size = new Size(80, 25);
            cmbYear.Font = new Font("Arial", 12);
            cmbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Controls.Add(cmbYear);

            // Address Label
            lblAddress = new Label();
            lblAddress.Text = "Address:";
            lblAddress.Location = new Point(30, 190);
            lblAddress.Size = new Size(120, 20);
            lblAddress.Font = new Font("Arial", 12, FontStyle.Bold);
            this.Controls.Add(lblAddress);

            // Address TextBox
            txtAddress = new TextBox();
            txtAddress.Location = new Point(160, 188);
            txtAddress.Size = new Size(300, 25);
            txtAddress.Font = new Font("Arial", 12);
            this.Controls.Add(txtAddress);

            // Display Button
            btnDisplay = new Button();
            btnDisplay.Text = "Display";
            btnDisplay.Location = new Point(30, 230);
            btnDisplay.Size = new Size(100, 40);
            btnDisplay.Font = new Font("Arial", 12);
            btnDisplay.BackColor = Color.Crimson;
            btnDisplay.ForeColor = Color.White;
            btnDisplay.FlatStyle = FlatStyle.Flat;
            btnDisplay.Click += new EventHandler(this.btnDisplay_Click);
            this.Controls.Add(btnDisplay);

            // Output Label
            lblOutput = new Label();
            lblOutput.Location = new Point(30, 280);
            lblOutput.Size = new Size(520, 150);
            lblOutput.Font = new Font("Arial", 12, FontStyle.Bold);
            lblOutput.BackColor = Color.LightGray;
            lblOutput.BorderStyle = BorderStyle.FixedSingle;
            lblOutput.TextAlign = ContentAlignment.TopLeft;
            lblOutput.Padding = new Padding(10);
            this.Controls.Add(lblOutput);

            this.ResumeLayout(false);
        }

        #endregion
    }
}
