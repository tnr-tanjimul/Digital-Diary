using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Diary
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (textUsername.Text.Length==0 || textPassword.Text.Length == 0 || textConfPassword.Text.Length == 0)
            {
                MessageBox.Show("Username & Password Cann't be blank");
            }
            else
            {
                if (textPassword.Text==textConfPassword.Text)
                {
                    Person person = new Person();
                    person.Username = textUsername.Text;
                    person.Password = textPassword.Text;

                    if (person.AddPerson()>0)
                    {
                        MessageBox.Show("Signup Successfull");
                        new Login().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Signup UnSuccessfull");
                    }
                }
                else
                {
                    MessageBox.Show("Passwprd and Confirm Password Must be Same");
                }
            }
        }
    }
}
