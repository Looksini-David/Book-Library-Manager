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
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            lstBooks.Items.Add(title + " by " + author);
            txtTitle.Clear();
            txtAuthor.Clear();
           

        }
    }
}
