﻿namespace MobileRegistrationForm
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
            this.fieldName = new System.Windows.Forms.TextBox();
            this.fieldSurname = new System.Windows.Forms.TextBox();
            this.fieldEmail = new System.Windows.Forms.TextBox();
            this.fieldPassword = new System.Windows.Forms.TextBox();
            this.fieldAge = new System.Windows.Forms.NumericUpDown();
            this.fieldPassowordRepeat = new System.Windows.Forms.TextBox();
            this.buttonSignIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fieldAge)).BeginInit();
            this.SuspendLayout();
            // 
            // fieldName
            // 
            this.fieldName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldName.Location = new System.Drawing.Point(12, 22);
            this.fieldName.Name = "fieldName";
            this.fieldName.Size = new System.Drawing.Size(379, 41);
            this.fieldName.TabIndex = 0;
            this.fieldName.Text = "fieldName";
            // 
            // fieldSurname
            // 
            this.fieldSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldSurname.Location = new System.Drawing.Point(12, 69);
            this.fieldSurname.Name = "fieldSurname";
            this.fieldSurname.Size = new System.Drawing.Size(379, 41);
            this.fieldSurname.TabIndex = 1;
            this.fieldSurname.Text = "fieldSurname";
            // 
            // fieldEmail
            // 
            this.fieldEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldEmail.Location = new System.Drawing.Point(12, 116);
            this.fieldEmail.Name = "fieldEmail";
            this.fieldEmail.Size = new System.Drawing.Size(379, 41);
            this.fieldEmail.TabIndex = 2;
            this.fieldEmail.Text = "fieldEmail";
            // 
            // fieldPassword
            // 
            this.fieldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldPassword.Location = new System.Drawing.Point(12, 230);
            this.fieldPassword.Name = "fieldPassword";
            this.fieldPassword.Size = new System.Drawing.Size(379, 41);
            this.fieldPassword.TabIndex = 3;
            this.fieldPassword.Text = "fieldPassword";
            // 
            // fieldAge
            // 
            this.fieldAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldAge.Location = new System.Drawing.Point(12, 163);
            this.fieldAge.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.fieldAge.Minimum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.fieldAge.Name = "fieldAge";
            this.fieldAge.Size = new System.Drawing.Size(120, 41);
            this.fieldAge.TabIndex = 4;
            this.fieldAge.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // fieldPassowordRepeat
            // 
            this.fieldPassowordRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldPassowordRepeat.Location = new System.Drawing.Point(12, 277);
            this.fieldPassowordRepeat.Name = "fieldPassowordRepeat";
            this.fieldPassowordRepeat.Size = new System.Drawing.Size(379, 41);
            this.fieldPassowordRepeat.TabIndex = 5;
            this.fieldPassowordRepeat.Text = "fieldPasswordRepeat";
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignIn.Location = new System.Drawing.Point(12, 392);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(379, 71);
            this.buttonSignIn.TabIndex = 6;
            this.buttonSignIn.Text = "Sign In";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 510);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.fieldPassowordRepeat);
            this.Controls.Add(this.fieldAge);
            this.Controls.Add(this.fieldPassword);
            this.Controls.Add(this.fieldEmail);
            this.Controls.Add(this.fieldSurname);
            this.Controls.Add(this.fieldName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fieldAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fieldName;
        private System.Windows.Forms.TextBox fieldSurname;
        private System.Windows.Forms.TextBox fieldEmail;
        private System.Windows.Forms.TextBox fieldPassword;
        private System.Windows.Forms.NumericUpDown fieldAge;
        private System.Windows.Forms.TextBox fieldPassowordRepeat;
        private System.Windows.Forms.Button buttonSignIn;
    }
}

