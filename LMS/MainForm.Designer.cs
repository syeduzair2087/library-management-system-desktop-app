namespace LMS
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.cmbMembers = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNoOfBooks = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.chkAvailableBooks = new System.Windows.Forms.CheckedListBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.lblBookId = new System.Windows.Forms.Label();
            this.btnLend = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDelMember = new System.Windows.Forms.Button();
            this.btnDelBook = new System.Windows.Forms.Button();
            this.chkBorrowedBooks = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(12, 12);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(75, 23);
            this.btnAddMember.TabIndex = 0;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(12, 70);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // cmbMembers
            // 
            this.cmbMembers.Location = new System.Drawing.Point(93, 13);
            this.cmbMembers.Name = "cmbMembers";
            this.cmbMembers.Size = new System.Drawing.Size(179, 21);
            this.cmbMembers.TabIndex = 2;
            this.cmbMembers.SelectionChangeCommitted += new System.EventHandler(this.cmbMembers_SelectionChangeCommitted);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 217);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID";
            // 
            // lblNoOfBooks
            // 
            this.lblNoOfBooks.AutoSize = true;
            this.lblNoOfBooks.Location = new System.Drawing.Point(12, 239);
            this.lblNoOfBooks.Name = "lblNoOfBooks";
            this.lblNoOfBooks.Size = new System.Drawing.Size(80, 13);
            this.lblNoOfBooks.TabIndex = 4;
            this.lblNoOfBooks.Text = "NO OF BOOKS";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(12, 41);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkAvailableBooks
            // 
            this.chkAvailableBooks.AccessibleName = "";
            this.chkAvailableBooks.FormattingEnabled = true;
            this.chkAvailableBooks.Location = new System.Drawing.Point(93, 41);
            this.chkAvailableBooks.Name = "chkAvailableBooks";
            this.chkAvailableBooks.Size = new System.Drawing.Size(179, 139);
            this.chkAvailableBooks.TabIndex = 6;
            this.chkAvailableBooks.SelectedIndexChanged += new System.EventHandler(this.chkAvailableBooks_SelectedIndexChanged);
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(12, 292);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(71, 13);
            this.lblBookName.TabIndex = 7;
            this.lblBookName.Text = "BOOK NAME";
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.AutoSize = true;
            this.lblBookAuthor.Location = new System.Drawing.Point(12, 314);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(86, 13);
            this.lblBookAuthor.TabIndex = 7;
            this.lblBookAuthor.Text = "BOOK AUTHOR";
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Location = new System.Drawing.Point(12, 270);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(51, 13);
            this.lblBookId.TabIndex = 7;
            this.lblBookId.Text = "BOOK ID";
            // 
            // btnLend
            // 
            this.btnLend.Location = new System.Drawing.Point(93, 187);
            this.btnLend.Name = "btnLend";
            this.btnLend.Size = new System.Drawing.Size(178, 23);
            this.btnLend.TabIndex = 8;
            this.btnLend.Text = "Lend Books";
            this.btnLend.UseVisualStyleBackColor = true;
            this.btnLend.Click += new System.EventHandler(this.btnLend_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(278, 186);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(175, 23);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return Books";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDelMember
            // 
            this.btnDelMember.Location = new System.Drawing.Point(12, 99);
            this.btnDelMember.Name = "btnDelMember";
            this.btnDelMember.Size = new System.Drawing.Size(75, 36);
            this.btnDelMember.TabIndex = 10;
            this.btnDelMember.Text = "Delete Member";
            this.btnDelMember.UseVisualStyleBackColor = true;
            this.btnDelMember.Click += new System.EventHandler(this.btnDelMember_Click);
            // 
            // btnDelBook
            // 
            this.btnDelBook.Location = new System.Drawing.Point(12, 141);
            this.btnDelBook.Name = "btnDelBook";
            this.btnDelBook.Size = new System.Drawing.Size(75, 39);
            this.btnDelBook.TabIndex = 11;
            this.btnDelBook.Text = "Delete Books";
            this.btnDelBook.UseVisualStyleBackColor = true;
            this.btnDelBook.Click += new System.EventHandler(this.btnDelBook_Click);
            // 
            // chkBorrowedBooks
            // 
            this.chkBorrowedBooks.FormattingEnabled = true;
            this.chkBorrowedBooks.Location = new System.Drawing.Point(278, 13);
            this.chkBorrowedBooks.Name = "chkBorrowedBooks";
            this.chkBorrowedBooks.Size = new System.Drawing.Size(175, 169);
            this.chkBorrowedBooks.TabIndex = 12;
            this.chkBorrowedBooks.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 358);
            this.Controls.Add(this.chkBorrowedBooks);
            this.Controls.Add(this.btnDelBook);
            this.Controls.Add(this.btnDelMember);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnLend);
            this.Controls.Add(this.lblBookAuthor);
            this.Controls.Add(this.lblBookId);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.chkAvailableBooks);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.lblNoOfBooks);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.cmbMembers);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnAddMember);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Library Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnLogOut;
        public System.Windows.Forms.ComboBox cmbMembers;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNoOfBooks;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.CheckedListBox chkAvailableBooks;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Button btnLend;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDelMember;
        private System.Windows.Forms.Button btnDelBook;
        private System.Windows.Forms.CheckedListBox chkBorrowedBooks;

        
    }
}