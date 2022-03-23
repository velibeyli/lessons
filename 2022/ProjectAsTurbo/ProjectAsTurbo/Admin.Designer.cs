
namespace ProjectAsTurbo
{
    partial class Admin
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
            this.button_add_annoucement = new System.Windows.Forms.Button();
            this.button_block_announcement = new System.Windows.Forms.Button();
            this.button_delete_announcement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_add_annoucement
            // 
            this.button_add_annoucement.Location = new System.Drawing.Point(13, 51);
            this.button_add_annoucement.Name = "button_add_annoucement";
            this.button_add_annoucement.Size = new System.Drawing.Size(256, 23);
            this.button_add_annoucement.TabIndex = 0;
            this.button_add_annoucement.Text = "Elan əlavə et";
            this.button_add_annoucement.UseVisualStyleBackColor = true;
            // 
            // button_block_announcement
            // 
            this.button_block_announcement.Location = new System.Drawing.Point(12, 95);
            this.button_block_announcement.Name = "button_block_announcement";
            this.button_block_announcement.Size = new System.Drawing.Size(256, 23);
            this.button_block_announcement.TabIndex = 0;
            this.button_block_announcement.Text = "Elanı blokla";
            this.button_block_announcement.UseVisualStyleBackColor = true;
            // 
            // button_delete_announcement
            // 
            this.button_delete_announcement.Location = new System.Drawing.Point(12, 140);
            this.button_delete_announcement.Name = "button_delete_announcement";
            this.button_delete_announcement.Size = new System.Drawing.Size(256, 23);
            this.button_delete_announcement.TabIndex = 0;
            this.button_delete_announcement.Text = "Elanı sil";
            this.button_delete_announcement.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.button_delete_announcement);
            this.Controls.Add(this.button_block_announcement);
            this.Controls.Add(this.button_add_annoucement);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_add_annoucement;
        private System.Windows.Forms.Button button_block_announcement;
        private System.Windows.Forms.Button button_delete_announcement;
    }
}

