using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            fieldName.ForeColor = Color.LightGray;
            fieldName.Tag = "Name";

            fieldSurname.Text = "Surname";
            fieldSurname.ForeColor = Color.LightGray;
            fieldSurname.Tag = "Surname";

            fieldEmail.Text = "Email";
            fieldEmail.ForeColor = Color.LightGray;
            fieldEmail.Tag = "Email";

            fieldPassword.Text = "Password";
            fieldPassword.ForeColor = Color.LightGray;
            fieldPassword.Tag = "Password";

            fieldPasswordRepeat.Text = "Repeat Password";
            fieldPasswordRepeat.ForeColor = Color.LightGray;
            fieldPasswordRepeat.Tag = "Repeat Password";
        }

        private void Field_Click(object sender, EventArgs e)
        {
            TextBox field = (TextBox)sender;
            if(field.Text == field.Tag)
            {
                field.Text = string.Empty;
                field.ForeColor = Color.Black;
            }           
        }
    }
}
