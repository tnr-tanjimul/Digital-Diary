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
    public partial class Login : Form
    {
        Authentication auth;
        public int loggedId;
        public Login()
        {
            InitializeComponent();
            this.auth = new Authentication();
        }

       

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Signup().Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textUsername.Text.Length==0 || textPassword.Text.Length==0)
            {
                MessageBox.Show("Username & Password Cann't be Blank");
               
            }
            else
            {
                this.loggedId = this.auth.Validate(new Person() { Username = textUsername.Text, Password = textPassword.Text });

                if (this.loggedId == 0)
                {
                    MessageBox.Show("Username or Password wrong");
                }
                else
                {
                    //MessageBox.Show("Login Success");
                    Diary diary = new Diary(this);
                    this.Hide();

                    diary.Show();
                }
            }
        }
    }
}
