namespace WindowsFormsAppPart5
{
    partial class BookStockApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.bookInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.bookDescriptionText = new System.Windows.Forms.RichTextBox();
            this.bookAuthorText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bookCountText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bookCategoryText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bookNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bookPicture = new System.Windows.Forms.PictureBox();
            this.bookInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitablar";
            // 
            // cmbBooks
            // 
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.Location = new System.Drawing.Point(60, 6);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(519, 21);
            this.cmbBooks.TabIndex = 1;
            this.cmbBooks.SelectedIndexChanged += new System.EventHandler(this.cmbBooks_SelectedIndexChanged);
            // 
            // bookInfoGroupBox
            // 
            this.bookInfoGroupBox.Controls.Add(this.bookDescriptionText);
            this.bookInfoGroupBox.Controls.Add(this.bookAuthorText);
            this.bookInfoGroupBox.Controls.Add(this.label5);
            this.bookInfoGroupBox.Controls.Add(this.bookCountText);
            this.bookInfoGroupBox.Controls.Add(this.label4);
            this.bookInfoGroupBox.Controls.Add(this.bookCategoryText);
            this.bookInfoGroupBox.Controls.Add(this.label3);
            this.bookInfoGroupBox.Controls.Add(this.bookNameText);
            this.bookInfoGroupBox.Controls.Add(this.label2);
            this.bookInfoGroupBox.Controls.Add(this.bookPicture);
            this.bookInfoGroupBox.Location = new System.Drawing.Point(12, 33);
            this.bookInfoGroupBox.Name = "bookInfoGroupBox";
            this.bookInfoGroupBox.Size = new System.Drawing.Size(567, 427);
            this.bookInfoGroupBox.TabIndex = 2;
            this.bookInfoGroupBox.TabStop = false;
            this.bookInfoGroupBox.Text = "Seçilən kitab haqqında məlumat";
            // 
            // bookDescriptionText
            // 
            this.bookDescriptionText.Location = new System.Drawing.Point(7, 257);
            this.bookDescriptionText.Name = "bookDescriptionText";
            this.bookDescriptionText.Size = new System.Drawing.Size(554, 164);
            this.bookDescriptionText.TabIndex = 3;
            this.bookDescriptionText.Text = "";
            // 
            // bookAuthorText
            // 
            this.bookAuthorText.Location = new System.Drawing.Point(246, 95);
            this.bookAuthorText.Name = "bookAuthorText";
            this.bookAuthorText.Size = new System.Drawing.Size(142, 20);
            this.bookAuthorText.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Müəllif";
            // 
            // bookCountText
            // 
            this.bookCountText.Location = new System.Drawing.Point(246, 69);
            this.bookCountText.Name = "bookCountText";
            this.bookCountText.Size = new System.Drawing.Size(142, 20);
            this.bookCountText.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Stok Ədəd";
            // 
            // bookCategoryText
            // 
            this.bookCategoryText.Location = new System.Drawing.Point(246, 43);
            this.bookCategoryText.Name = "bookCategoryText";
            this.bookCategoryText.Size = new System.Drawing.Size(142, 20);
            this.bookCategoryText.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kateqoriya";
            // 
            // bookNameText
            // 
            this.bookNameText.Location = new System.Drawing.Point(246, 17);
            this.bookNameText.Name = "bookNameText";
            this.bookNameText.Size = new System.Drawing.Size(142, 20);
            this.bookNameText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitabın Adı";
            // 
            // bookPicture
            // 
            this.bookPicture.Location = new System.Drawing.Point(6, 19);
            this.bookPicture.Name = "bookPicture";
            this.bookPicture.Size = new System.Drawing.Size(170, 231);
            this.bookPicture.TabIndex = 0;
            this.bookPicture.TabStop = false;
            // 
            // BookStockApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 472);
            this.Controls.Add(this.bookInfoGroupBox);
            this.Controls.Add(this.cmbBooks);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BookStockApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitab Stok Proqramı";
            this.Load += new System.EventHandler(this.BookStoreApp_Load);
            this.bookInfoGroupBox.ResumeLayout(false);
            this.bookInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBooks;
        private System.Windows.Forms.GroupBox bookInfoGroupBox;
        private System.Windows.Forms.TextBox bookAuthorText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bookCountText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bookCategoryText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bookNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox bookPicture;
        private System.Windows.Forms.RichTextBox bookDescriptionText;
    }
}

