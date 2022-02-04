using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApplicationHomework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = textBox1.Text;
            Form2 form2 = new Form2(txt);
            form2.Show();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            text.Text = string.Empty;
        }
    }
}
