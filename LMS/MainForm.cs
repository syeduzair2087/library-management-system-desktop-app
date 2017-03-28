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


    public partial class MainForm : Form
    {
        void LoadLists()
        {

            chkAvailableBooks.Items.Clear();
            chkBorrowedBooks.Items.Clear();


            if (cmbMembers.SelectedItem != null)
            {
                chkAvailableBooks.Items.AddRange(General.GetAvailableBooks((Member)cmbMembers.SelectedItem).ToArray());
                chkBorrowedBooks.Items.AddRange(((Member)cmbMembers.SelectedItem).booksBorrowed.ToArray());
            }

            else
                chkAvailableBooks.Items.AddRange(General.Books.ToArray());
        }

        void LoadMembers(int Index)
        {
            cmbMembers.Items.Clear();
            cmbMembers.Items.AddRange(General.Members.ToArray());
            cmbMembers.SelectedIndex = Index;
            if (Index == -1)
                cmbMembers.Text = "";
        }

        void LoadMemberLabels()
        {
            if (cmbMembers.SelectedItem != null)
            {
                lblID.Text = "MEMBER ID : " + ((Member)cmbMembers.SelectedItem).ID;
                lblNoOfBooks.Text = "BOOKS BORROWED : " + ((Member)cmbMembers.SelectedItem).booksBorrowed.Count.ToString();
            }

            else
            {
                lblID.Text = "";
                lblNoOfBooks.Text = "";
            }
        }

        void LoadBookLabels(CheckedListBox BookBox)
        {
            if (BookBox.SelectedItem != null)
            {
                lblBookId.Text = "BOOK ID : " + ((Book)BookBox.SelectedItem).BookID;
                lblBookName.Text = "BOOK NAME : " + ((Book)BookBox.SelectedItem).BookName;
                lblBookAuthor.Text = "BOOK AUTHOR : " + ((Book)BookBox.SelectedItem).Author;
            }

            else
            {
                lblBookId.Text = "";
                lblBookName.Text = "";
                lblBookAuthor.Text = "";
            }
        }

        public bool IsLoggingOut = false;
        public Form Login
        {
            get;
            set;
        }

        public MainForm()
        {

            General.Load_Data();
            InitializeComponent();
            lblID.Text = "";
            lblNoOfBooks.Text = "";
            lblBookId.Text = "";
            lblBookName.Text = "";
            lblBookAuthor.Text = "";
            cmbMembers.DisplayMember = "Name";
            chkAvailableBooks.DisplayMember = "BookName";
            chkBorrowedBooks.DisplayMember = "BookName";
            LoadMembers(-1);
            LoadLists();
        }


        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsLoggingOut)
            {
                if (MessageBox.Show("Are you sure you want to exit the program?", "Exit", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                {
                    e.Cancel = true;
                }

                General.SaveData();
            }

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out from the system?", "Log Out", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                IsLoggingOut = true;
                this.Hide();
                this.Login.Show();
            }
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            AddMemberForm AddNewMember = new AddMemberForm();
            AddNewMember.ShowDialog();
            LoadMembers(cmbMembers.SelectedIndex);
            LoadLists();
        }


        private void cmbMembers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadMemberLabels();
            LoadLists();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddBookForm AddNewBook = new AddBookForm();
            AddNewBook.ShowDialog();
            LoadLists();
        }

        private void chkAvailableBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkAvailableBooks.SelectedIndex != null)
                LoadBookLabels(chkAvailableBooks);
        }

        private void btnLend_Click(object sender, EventArgs e)
        {
            if (((Member)cmbMembers.SelectedItem) != null)
            {
                if (chkAvailableBooks.CheckedItems.Count != 0)
                {
                    if (((Member)cmbMembers.SelectedItem).booksBorrowed.Count() < 10)
                    {
                        ((Member)cmbMembers.SelectedItem).booksBorrowed.AddRange(chkAvailableBooks.CheckedItems.Cast<Book>());

                        LoadMembers(cmbMembers.SelectedIndex);
                        LoadMemberLabels();
                        LoadLists();
                    }

                    else
                        MessageBox.Show("Sorry, the member has already borrowed 10 books. Please try again when the books have been returned.", "Error");

                }

                else
                    MessageBox.Show("Please select atleast one book to lend!", "Error");
            }

            else
                MessageBox.Show("Please select a member first!", "Error");




        }

        private void button2_Click(object sender, EventArgs e) //RETURN BUTTON
        {
            Member CurrentMember = (Member)cmbMembers.SelectedItem;
            if (CurrentMember != null)
            {
                List<Book> ForRemoval = chkBorrowedBooks.CheckedItems.OfType<Book>().ToList();

                if (ForRemoval.Count > 0)
                {
                    foreach (Book b in ForRemoval)
                    {
                        CurrentMember.booksBorrowed.Remove(CurrentMember.booksBorrowed.Find(item => item.BookID == b.BookID));
                    }
                    LoadLists();
                    LoadMemberLabels();
                }
                else
                    MessageBox.Show("Please select atleast one book to return!", "Error");
            }
            else
                MessageBox.Show("Please select a member first!", "Error");
        }

        private void btnDelMember_Click(object sender, EventArgs e)
        {
            if (cmbMembers.SelectedItem != null)
            {
                General.Members.Remove((Member)cmbMembers.SelectedItem);
                LoadMembers(cmbMembers.SelectedIndex - 1);
                LoadMemberLabels();
                LoadLists();
                MessageBox.Show("Member was successfully removed!", "Success");
            }

            else
                MessageBox.Show("Please select a member first!", "Error");
        }

        private void btnDelBook_Click(object sender, EventArgs e)
        {

            List<Book> ForDeletion = chkAvailableBooks.CheckedItems.OfType<Book>().ToList();
            if (ForDeletion.Count > 0)
            {
                bool IsBorrowed = false;
                foreach (Book b in ForDeletion)
                {
                    foreach (Member m in General.Members)
                    {
                        if (m.booksBorrowed.Contains(b))
                        {
                            IsBorrowed = true;
                            break;
                        }

                    }
                }



                if (IsBorrowed)
                    MessageBox.Show("One or more of the selected books are currently borrowed by one or more members.\nPlease try again after the book has been returned.", "Error");

                else if (!IsBorrowed)
                {
                    foreach (Book b in ForDeletion)
                    {
                        General.Books.Remove(b);
                    }
                    LoadLists();
                    MessageBox.Show("Books were successfully deleted.", "Success");
                }
            }

            else
                MessageBox.Show("Please select atleast one book to delete!", "Error");
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkBorrowedBooks.SelectedIndex != null)
                LoadBookLabels(chkBorrowedBooks);
        }

    }
}
