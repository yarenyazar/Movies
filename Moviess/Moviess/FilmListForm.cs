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
    public partial class FilmListForm : Form
    {
        public FilmListForm()
        {
            InitializeComponent();
        }
        private void addMovie_Click(object sender, EventArgs e)
        {
            FilmForm filmForm = new FilmForm();
            this.Hide();
            filmForm.Show();
        }

        private void FilmListForm_Load(object sender, EventArgs e)
        {
            DbManagement.getFilms();
            dataGridViewFilms.Rows.Clear();

            dataGridViewFilms.DataSource = DbManagement.dataSet.Tables["Films"];

            dataGridViewFilms.Columns["FilmName"].HeaderText = "Film Adı";
            dataGridViewFilms.Columns["WatchDate"].HeaderText = "İzleme Tarihi";
            dataGridViewFilms.Columns["Rating"].HeaderText = "Puan";
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            // kullanıcı oturumunu kapat
            DbManagement.AuthUserName = ""; // oturum bilgisi temizlenir

            Login loginForm = new Login();
            this.Hide();
            loginForm.Show();
        }
    }
}
