
namespace BookStore
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BookName = new System.Windows.Forms.TextBox();
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.BookAuthorLabel = new System.Windows.Forms.Label();
            this.BookAuthor = new System.Windows.Forms.TextBox();
            this.AddBookBtn = new System.Windows.Forms.Button();
            this.BooksList = new System.Windows.Forms.Label();
            this.BookList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BookName
            // 
            this.BookName.Location = new System.Drawing.Point(53, 6);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(125, 20);
            this.BookName.TabIndex = 0;
            // 
            // BookNameLabel
            // 
            this.BookNameLabel.AutoSize = true;
            this.BookNameLabel.Location = new System.Drawing.Point(12, 9);
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Size = new System.Drawing.Size(35, 13);
            this.BookNameLabel.TabIndex = 1;
            this.BookNameLabel.Text = "Name";
            this.BookNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // BookAuthorLabel
            // 
            this.BookAuthorLabel.AutoSize = true;
            this.BookAuthorLabel.Location = new System.Drawing.Point(12, 45);
            this.BookAuthorLabel.Name = "BookAuthorLabel";
            this.BookAuthorLabel.Size = new System.Drawing.Size(38, 13);
            this.BookAuthorLabel.TabIndex = 2;
            this.BookAuthorLabel.Text = "Author";
            // 
            // BookAuthor
            // 
            this.BookAuthor.Location = new System.Drawing.Point(53, 42);
            this.BookAuthor.Name = "BookAuthor";
            this.BookAuthor.Size = new System.Drawing.Size(125, 20);
            this.BookAuthor.TabIndex = 3;
            // 
            // AddBookBtn
            // 
            this.AddBookBtn.Location = new System.Drawing.Point(103, 78);
            this.AddBookBtn.Name = "AddBookBtn";
            this.AddBookBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBookBtn.TabIndex = 4;
            this.AddBookBtn.Text = "Add";
            this.AddBookBtn.UseVisualStyleBackColor = true;
            this.AddBookBtn.Click += new System.EventHandler(this.AddBookBtn_Click);
            // 
            // BooksList
            // 
            this.BooksList.AutoSize = true;
            this.BooksList.Location = new System.Drawing.Point(490, 13);
            this.BooksList.Name = "BooksList";
            this.BooksList.Size = new System.Drawing.Size(37, 13);
            this.BooksList.TabIndex = 5;
            this.BooksList.Text = "Books";
            // 
            // BookList
            // 
            this.BookList.FormattingEnabled = true;
            this.BookList.Location = new System.Drawing.Point(406, 64);
            this.BookList.Name = "BookList";
            this.BookList.Size = new System.Drawing.Size(120, 95);
            this.BookList.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BookList);
            this.Controls.Add(this.BooksList);
            this.Controls.Add(this.AddBookBtn);
            this.Controls.Add(this.BookAuthor);
            this.Controls.Add(this.BookAuthorLabel);
            this.Controls.Add(this.BookNameLabel);
            this.Controls.Add(this.BookName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BookStore";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.Label BookNameLabel;
        private System.Windows.Forms.Label BookAuthorLabel;
        private System.Windows.Forms.TextBox BookAuthor;
        private System.Windows.Forms.Button AddBookBtn;
        private System.Windows.Forms.Label BooksList;
        private System.Windows.Forms.ListBox BookList;
    }
}

