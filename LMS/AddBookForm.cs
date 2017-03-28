using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrWhiteSpace(txtBookName.Text)) && !(String.IsNullOrWhiteSpace(txtAuthorName.Text)))
            {
                if (txtAuthorName.Text.Any(char.IsDigit))
                {
                    Book MyBook = new Book(txtBookName.Text, txtAuthorName.Text);
                    General.Books.Add(MyBook);
                    MessageBox.Show("Book added successfully!\nPress OK to return", "Success");
                    this.Close();
                }

                else
                    MessageBox.Show("The author name must only contain letters!", "Error");
            }

            else
                MessageBox.Show("No field can be left empty!", "Error");
        }
    }
}
