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
    public partial class LoginForm : Form
    {
        public bool ClosedFrom2 = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "admin" && txtPass.Text == "admin")
            {
                MainForm myform2 = new MainForm();
                myform2.Login = this;
                this.Hide();
                myform2.ShowDialog();

            }

            else
            {
                MessageBox.Show("Please enter a valid username and password!", "Error");
            }
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            txtName.Text = null;
            txtPass.Text = null;
            txtName.Focus();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you sure you want to exit the program?", "Exit", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                {
                    e.Cancel = true;
                }

                else
                    General.SaveData();
            }
        }
    }
}
