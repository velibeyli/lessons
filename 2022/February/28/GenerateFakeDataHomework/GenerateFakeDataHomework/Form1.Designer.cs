
namespace GenerateFakeDataHomework
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
            this.dataGridViewGeneratePerson = new System.Windows.Forms.DataGridView();
            this.GeneratePersonBtn = new System.Windows.Forms.Button();
            this.PersonStatisticBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGeneratePerson)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGeneratePerson
            // 
            this.dataGridViewGeneratePerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGeneratePerson.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewGeneratePerson.MultiSelect = false;
            this.dataGridViewGeneratePerson.Name = "dataGridViewGeneratePerson";
            this.dataGridViewGeneratePerson.Size = new System.Drawing.Size(877, 601);
            this.dataGridViewGeneratePerson.TabIndex = 0;
            // 
            // GeneratePersonBtn
            // 
            this.GeneratePersonBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.GeneratePersonBtn.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GeneratePersonBtn.ForeColor = System.Drawing.Color.White;
            this.GeneratePersonBtn.Location = new System.Drawing.Point(13, 630);
            this.GeneratePersonBtn.Name = "GeneratePersonBtn";
            this.GeneratePersonBtn.Size = new System.Drawing.Size(251, 35);
            this.GeneratePersonBtn.TabIndex = 1;
            this.GeneratePersonBtn.Text = "Generate Person";
            this.GeneratePersonBtn.UseVisualStyleBackColor = false;
            this.GeneratePersonBtn.Click += new System.EventHandler(this.GeneratePersonBtn_Click);
            // 
            // PersonStatisticBtn
            // 
            this.PersonStatisticBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PersonStatisticBtn.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.PersonStatisticBtn.ForeColor = System.Drawing.Color.White;
            this.PersonStatisticBtn.Location = new System.Drawing.Point(318, 631);
            this.PersonStatisticBtn.Name = "PersonStatisticBtn";
            this.PersonStatisticBtn.Size = new System.Drawing.Size(251, 35);
            this.PersonStatisticBtn.TabIndex = 2;
            this.PersonStatisticBtn.Text = "Get Person Statistics";
            this.PersonStatisticBtn.UseVisualStyleBackColor = false;
            this.PersonStatisticBtn.Click += new System.EventHandler(this.PersonStatisticBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 749);
            this.Controls.Add(this.PersonStatisticBtn);
            this.Controls.Add(this.GeneratePersonBtn);
            this.Controls.Add(this.dataGridViewGeneratePerson);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGeneratePerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGeneratePerson;
        private System.Windows.Forms.Button GeneratePersonBtn;
        private System.Windows.Forms.Button PersonStatisticBtn;
    }
}

