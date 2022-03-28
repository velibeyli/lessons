using ProjectAsTurbo.Enums;
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
        public static string passingUser;
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

        private void label2_Click(object sender, EventArgs e)
        {
            CreateAdvertisement advertisement = new CreateAdvertisement();
            advertisement.Show();
            this.Close();
        }

        private void DetailedSearch_Load(object sender, EventArgs e)
        {
            VirtualDatabase db = new VirtualDatabase();
            foreach (var item in db.Brands)
            {
                comboBox_all_brands.Items.Add(item);
            }

            foreach (var item in db.Cities)
            {
                comboBox_allCities.Items.Add(item);
            }
            foreach (var item in Enum.GetValues(typeof(FuelType)))
            {
                comboBox_allFuelTypes.Items.Add(item);
            }
            foreach (var item in Enum.GetValues(typeof(BodyType)))
            {
                comboBox_allTypes.Items.Add(item);
            }
            foreach (var item in Enum.GetValues(typeof(Transmitter)))
            {
                comboBox_allTransmitter.Items.Add(item);
            }
            foreach (var item in Enum.GetValues(typeof(Transmission)))
            {
                comboBox_allTransmission.Items.Add(item);
            }
            foreach (var item in db.AllColor)
            {
                comboBox_allColor.Items.Add(item);
            }
            foreach (var item in Enum.GetValues(typeof(Currency)))
            {
                comboBox_currency.Items.Add(item);
            }
            for (int i = DateTime.Now.Year; i >= (DateTime.Now.Year-120); i--)
            {
                comboBox_prodDateMin.Items.Add(i);
                comboBox_prodDateMax.Items.Add(i);
            }
            for (int i = 100; i <= 16000;)
            {
                //if (i > 6500 && i < 7000)
                //{
                //    continue;
                //}
                comboBox_engineMin.Items.Add(i);
                comboBox_engineMax.Items.Add(i);
                i += 100;
            }

            if (passingUser == null)
                label_enter_site.Text = "Giriş";
            else
                label_enter_site.Text = passingUser;
        }

        private void label_enter_site_Click(object sender, EventArgs e)
        {
            Authentication userLogin = new Authentication();
            userLogin.Show();

            if (label_enter_site.Text != "Giriş")
            {
                userLogin.Close();
                DialogResult result = MessageBox.Show("Hesabınızdan çıxmaq istəyirsiniz?", "Logout", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    label_enter_site.Text = "Giriş";
                }
            }
            this.Close();
        }
    }
}
