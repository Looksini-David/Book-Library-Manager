using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Library_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string author = txtAuthor.Text.Trim();

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Book title cannot be empty.");
                return;
            }

            if (string.IsNullOrWhiteSpace(author) || author.Any(char.IsDigit))
            {
                MessageBox.Show("Author name must not contain numbers.");
                return;
            }
            lstBooks.Items.Add($"{title} by {author}");
            txtTitle.Clear();
            txtAuthor.Clear();



        }
    }
}
