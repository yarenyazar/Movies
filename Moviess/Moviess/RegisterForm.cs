using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moviess
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        
        Login loginForm = new Login();
        private void signUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userNameTextBox.Text) ||
                string.IsNullOrEmpty(passwordTextBox.Text)) 
            {
                MessageBox.Show("Fill out all information completely!");          
            }
            else
            {
                DbManagement.addUser(userNameTextBox.Text, passwordTextBox.Text);
                loginForm.Show();
            }
        }
        private void lblLogin_Click(object sender, EventArgs e)
        {            
            this.Hide();
            loginForm.Show();
        }
    }
}
