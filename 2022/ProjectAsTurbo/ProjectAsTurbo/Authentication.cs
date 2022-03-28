using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAsTurbo
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void button_enterWithPhone_Click(object sender, EventArgs e)
        {
            EnterCabinet cabinet = new EnterCabinet();
            cabinet.Show();
            this.Close();
        }
    }
}
