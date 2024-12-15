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
    public partial class FilmForm : Form
    {
        public FilmForm()
        {
            InitializeComponent();
        }
        private void btnAddFilm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filmNameTextBox.Text) ||
                string.IsNullOrEmpty(watchDateTextBox.Text) ||
                ratingNumericUpdwn.Value == 0) 
            {
                MessageBox.Show("Fill in all the blanks!");
            }
            else
            {
                int numericValue = (int)ratingNumericUpdwn.Value;
                DbManagement.addFilm(filmNameTextBox.Text, watchDateTextBox.Text,numericValue);
                this.Hide();
                FilmListForm filmListForm = new FilmListForm();
                filmListForm.Show();
            }
        }
    }
}
