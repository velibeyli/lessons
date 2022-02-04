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
    public partial class Form2 : Form
    {
        public Form2(string txt)
        {
            InitializeComponent();
            label2.Text = txt;
        }

    }
}
