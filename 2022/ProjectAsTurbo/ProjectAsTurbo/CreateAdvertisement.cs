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
    public partial class CreateAdvertisement : Form
    {
        WEB web = new WEB();
        public static string passingUser;
        public CreateAdvertisement()
        {
            InitializeComponent();
        }

        private void label_turbo_az_Click(object sender, EventArgs e)
        {
            web.Show();
            this.Close();
        }

        private void CreateAdvertisement_Load(object sender, EventArgs e)
        {
            panel_sparePartsDropD.Height = 50;

            VirtualDatabase db = new VirtualDatabase();
            foreach (var item in db.Brands)
            {
                comboBox_all_brands.Items.Add(item);
            }
            foreach (var item in db.Cities)
            {
                comboBox_allCities.Items.Add(item);
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
            for (int i = DateTime.Now.Year; i >= (DateTime.Now.Year-120); i--)
            {
                comboBox_prodDate.Items.Add(i);
            }

            foreach (var item in Enum.GetValues(typeof(FuelType)))
            {
                comboBox_allFuelTypes.Items.Add(item);
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

                DialogResult result =  MessageBox.Show("Hesabınızdan çıxmaq istəyirsiniz?", "Logout", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    WEB.passingUser = "Giriş";
                }
                this.Close();
            }
            
        }

        private void label_bina_az_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bina.az");
        }

        private void label_tap_az_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://tap.az");
        }

        private void label_boss_az_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://boss.az");
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

        private void label_spare_parts_Click(object sender, EventArgs e)
        {
            if (panel_sparePartsDropD.Height == 270)
            {
                panel_sparePartsDropD.Height = 50;
            }
            else
            {
                panel_sparePartsDropD.Height = 270;
            }
        }

        private void label_all_announcement_MouseHover(object sender, EventArgs e)
        {
            label_all_announcement.BackColor = Color.Red;
        }

        private void label_all_announcement_MouseLeave(object sender, EventArgs e)
        {
            label_all_announcement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }

        private void label_autoshops_MouseHover(object sender, EventArgs e)
        {
            label_autoshops.BackColor = Color.Red;
        }

        private void label_autoshops_MouseLeave(object sender, EventArgs e)
        {
            label_autoshops.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }

        private void label_spare_parts_MouseHover(object sender, EventArgs e)
        {
            label_spare_parts.BackColor = Color.Red;
        }

        private void label_spare_parts_MouseLeave(object sender, EventArgs e)
        {
            label_spare_parts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }
    }
}
