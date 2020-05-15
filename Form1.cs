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

            registeredUsersListView.Columns.Add("Name");
            registeredUsersListView.Columns.Add("Surname");
            registeredUsersListView.Columns.Add("Email");
            registeredUsersListView.Columns.Add("Age");
            registeredUsersListView.Columns.Add("Password");
        }

        private void Field_Enter(object sender, EventArgs e)
        {  
            TextBox field = (TextBox)sender;
            if(field.Text == (string)field.Tag)
            {
                field.Text = string.Empty;
                field.ForeColor = Color.Black;

                if((string)field.Tag == "Password" || (string)field.Tag == "Password Repeat")
                {
                    field.PasswordChar = '*';
                }

            }           

        }

        private void Field_Leave(object sender, EventArgs e)
        {
            TextBox field = (TextBox)sender;
            if(field.Text == string.Empty)
            {
                field.Text = (string)field.Tag;
                field.ForeColor = Color.LightGray;

                if ((string)field.Tag == "Password" || (string)field.Tag == "Password Repeat")
                {
                    field.PasswordChar = '\0';
                }
            }
        }

        private void checkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPassword.Checked)
            {
                fieldPassword.PasswordChar = '\0';
                fieldPasswordRepeat.PasswordChar = '\0';
            }
            else
            {
                if(fieldPassword.Text != (string)fieldPassword.Tag)
                {
                    fieldPassword.PasswordChar = '*';
                }
                if(fieldPasswordRepeat.Text != (string)fieldPasswordRepeat.Tag)
                {
                    fieldPasswordRepeat.PasswordChar = '*';
                }                
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            if(fieldPassword.Text != fieldPasswordRepeat.Text)
            {
                //passwords are not equal
                fieldPassword.BackColor = Color.Salmon;
                fieldPasswordRepeat.BackColor = Color.Salmon;
                return;
            }
            else if (fieldPassword.Text == fieldPasswordRepeat.Text)
            {
                fieldPassword.BackColor = Color.Green;
                fieldPasswordRepeat.BackColor = Color.Green;
            }

            var item = new ListViewItem(new[] { fieldName.Text, fieldSurname.Text,  fieldEmail.Text, fieldAge.Value.ToString(), fieldPassword.Text});
            registeredUsersListView.Items.Add(item);
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            if(fieldPassword.Text == (string)fieldPassword.Tag || fieldPasswordRepeat.Text == (string)fieldPasswordRepeat.Tag)
            {
                return;
            }
            
            if (fieldPassword.Text == fieldPasswordRepeat.Text)
            {
                fieldPassword.BackColor = Color.LightGreen;
                fieldPasswordRepeat.BackColor = Color.LightGreen;
            }
            else
            {
                fieldPassword.BackColor = Color.Salmon;
                fieldPasswordRepeat.BackColor = Color.Salmon;
            }
        }
    }
}
