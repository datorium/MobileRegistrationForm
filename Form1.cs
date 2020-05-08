using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileRegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            fieldName.Text = "Name";
            fieldName.Tag = "Name";
            fieldName.ForeColor = Color.LightGray;

            fieldSurname.Text = "Surname";
            fieldSurname.Tag = "Surname";
            fieldSurname.ForeColor = Color.LightGray;

            fieldEmail.Text = "Email";
            fieldEmail.Tag = "Email";
            fieldEmail.ForeColor = Color.LightGray;

            fieldPassword.Text = "Password";
            fieldPassword.Tag = "Password";
            fieldPassword.ForeColor = Color.LightGray;

            fieldPasswordRepeat.Text = "Password Repeat";
            fieldPasswordRepeat.Tag = "Password Repeat";
            fieldPasswordRepeat.ForeColor = Color.LightGray;
        }

        private void Field_Enter(object sender, EventArgs e)
        {  
            TextBox field = (TextBox)sender;
            if(field.Text == (string)field.Tag)
            {
                field.Text = string.Empty;
                field.ForeColor = Color.Black;
            }           

        }
    }
}
