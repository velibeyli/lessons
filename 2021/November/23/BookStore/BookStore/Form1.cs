using BookStore.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (Context context = new Context())
            {
                context.Students.Create();
            }
        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            var bookName = BookName;
            var author = BookAuthor;
            BookList.Items.Add("dc");
            BookList.Items.Add("dasc");
        }
    }
}
