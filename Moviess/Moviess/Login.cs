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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            DbManagement.CreateDatabase();
            DbManagement.CreateTables();
        }
        private void ClickToRegisterClcik(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.Show();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userNameTextBox.Text) ||
                string.IsNullOrEmpty(passwordTextBox.Text))
            {

                MessageBox.Show("Fill out all information completely!");
            }
            else
            {
                bool success = false;
                success = DbManagement.login(userNameTextBox.Text, passwordTextBox.Text);
                if (success)
                {
                    MessageBox.Show("Logged in successfully!");
                    FilmListForm filmListForm = new FilmListForm();
                    this.Hide();
                    filmListForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!");
                }         
            }
        }
    }
}
