
namespace ProjectAsTurbo
{
    partial class VerifyNumber
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_getNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_verifyOTP = new System.Windows.Forms.TextBox();
            this.button_verify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(553, 237);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(385, 311);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(656, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nömrənin təsdiqlənməsi";
            // 
            // label_getNumber
            // 
            this.label_getNumber.AutoSize = true;
            this.label_getNumber.BackColor = System.Drawing.Color.White;
            this.label_getNumber.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_getNumber.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_getNumber.Location = new System.Drawing.Point(603, 377);
            this.label_getNumber.Name = "label_getNumber";
            this.label_getNumber.Size = new System.Drawing.Size(288, 19);
            this.label_getNumber.TabIndex = 3;
            this.label_getNumber.Text = "şşşşşşşşş nömrəsinə SMS kod göndərildi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(603, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "SMS-kod";
            // 
            // textBox_verifyOTP
            // 
            this.textBox_verifyOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_verifyOTP.Location = new System.Drawing.Point(607, 442);
            this.textBox_verifyOTP.Name = "textBox_verifyOTP";
            this.textBox_verifyOTP.Size = new System.Drawing.Size(284, 29);
            this.textBox_verifyOTP.TabIndex = 4;
            this.textBox_verifyOTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_verify
            // 
            this.button_verify.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_verify.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_verify.ForeColor = System.Drawing.Color.White;
            this.button_verify.Location = new System.Drawing.Point(607, 478);
            this.button_verify.Name = "button_verify";
            this.button_verify.Size = new System.Drawing.Size(284, 41);
            this.button_verify.TabIndex = 5;
            this.button_verify.Text = "Təsdiqlə";
            this.button_verify.UseVisualStyleBackColor = false;
            this.button_verify.Click += new System.EventHandler(this.button_verify_Click);
            // 
            // VerifyNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.button_verify);
            this.Controls.Add(this.textBox_verifyOTP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_getNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VerifyNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerifyNumber";
            this.Load += new System.EventHandler(this.VerifyNumber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_getNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_verifyOTP;
        private System.Windows.Forms.Button button_verify;
    }
}