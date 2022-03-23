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
    public partial class CreateAdvertisement : Form
    {
        public CreateAdvertisement()
        {
            InitializeComponent();
        }

        private void label_turbo_az_Click(object sender, EventArgs e)
        {
            WEB web = new WEB();
            web.Show();
            this.Close();
        }
    }
}
