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
    public partial class DetailedSearch : Form
    {
        public DetailedSearch()
        {
            InitializeComponent();
        }

        private void label_bina_az_MouseHover(object sender, EventArgs e)
        {
            label_bina_az.BackColor = Color.LightSalmon;
        }

        private void label_bina_az_MouseLeave(object sender, EventArgs e)
        {
            label_bina_az.BackColor = Color.Gray;
        }

        private void label_tap_az_MouseHover(object sender, EventArgs e)
        {
            label_tap_az.BackColor = Color.OrangeRed;
        }

        private void label_tap_az_MouseLeave(object sender, EventArgs e)
        {
            label_tap_az.BackColor = Color.Gray;
        }

        private void label_boss_az_MouseHover(object sender, EventArgs e)
        {
            label_boss_az.BackColor = Color.Gold;
        }

        private void label_boss_az_MouseLeave(object sender, EventArgs e)
        {
            label_boss_az.BackColor = Color.Gray;
        }

        private void label_turbo_az_Click(object sender, EventArgs e)
        {
            WEB mainPage = new WEB();
            mainPage.Show();
            this.Close();
        }
    }
}
