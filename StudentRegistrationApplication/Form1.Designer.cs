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
        }

        #endregion
    }
}
