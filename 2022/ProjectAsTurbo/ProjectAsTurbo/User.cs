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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            CreateAdvertisement advertisement = new CreateAdvertisement();
            advertisement.Show();
            this.Close();
        }

        private void label_turbo_az_Click(object sender, EventArgs e)
        {
            WEB mainPage = new WEB();
            mainPage.Show();
            this.Close();
        }
    }
}
