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
    public partial class AddMemberForm : Form
    {

        public AddMemberForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!(txtName.Text.Any(char.IsDigit)) && !(String.IsNullOrWhiteSpace(txtName.Text)))
            {
                Member MyMember = new Member(txtName.Text);
                General.Members.Add(MyMember);
                MessageBox.Show("Member added successfully!\nPress OK to return", "Success");
                this.Close();
            }

            else if (String.IsNullOrWhiteSpace(txtName.Text))
                MessageBox.Show("The name cannot be empty!", "Error");

            else
                MessageBox.Show("The name must only contain letters!", "Error");
        }
    }
}
