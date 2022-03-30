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
    public partial class WEB : Form
    {
        public static string passingUser;
        public WEB()
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

        private void label_boss_az_MouseHover(object sender, EventArgs e)
        {
            label_boss_az.BackColor = Color.Gold;
        }

        private void label_tap_az_MouseLeave(object sender, EventArgs e)
        {
            label_tap_az.BackColor = Color.Gray;
        }

        private void label_boss_az_MouseLeave(object sender, EventArgs e)
        {
            label_boss_az.BackColor = Color.Gray;
        }

        private void button_detailedSearch_Click(object sender, EventArgs e)
        {
            DetailedSearch search = new DetailedSearch();
            search.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            CreateAdvertisement advertisement = new CreateAdvertisement();
            advertisement.Show();
        }

        private void WEB_Load(object sender, EventArgs e)
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
            for (int i = DateTime.Now.Year; i >= (DateTime.Now.Year-120); i--)
            {
                comboBox_min_year.Items.Add(i);
                comboBox_max_year.Items.Add(i);
            }
            foreach (var item in Enum.GetValues(typeof(Currency)))
            {
                comboBox_currency.Items.Add(item);
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

        private void label_all_announcement_MouseLeave(object sender, EventArgs e)
        {
            label_all_announcement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }

        private void label_all_announcement_MouseHover(object sender, EventArgs e)
        {
            label_all_announcement.BackColor = Color.Red;
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

        private void comboBox_all_brands_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_all_models.Items.Clear();
            if (comboBox_all_brands.SelectedItem == "Abarth")
            {
                foreach (var item in DatabaseCarModels.Abart)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Acura")
            {
                foreach (var item in DatabaseCarModels.Acura)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Alfa Romeo")
            {
                foreach (var item in DatabaseCarModels.AlfaRomeo)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Aprilia")
            {
                foreach (var item in DatabaseCarModels.Aprilia)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Arctic Cat")
            {
                foreach (var item in DatabaseCarModels.ArcticCat)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Aston Martin")
            {
                foreach (var item in DatabaseCarModels.AstonMartin)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "ATV")
            {
                foreach (var item in DatabaseCarModels.ATV)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Audi")
            {
                foreach (var item in DatabaseCarModels.Audi)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Avia")
            {
                foreach (var item in DatabaseCarModels.Avia)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Baic")
            {
                foreach (var item in DatabaseCarModels.Baic)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Bajaj")
            {
                foreach (var item in DatabaseCarModels.Bajaj)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Benelli")
            {
                foreach (var item in DatabaseCarModels.Benelli)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Bentley")
            {
                foreach (var item in DatabaseCarModels.Bentley)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Bestune")
            {
                foreach (var item in DatabaseCarModels.Bestune)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "BMW")
            {
                foreach (var item in DatabaseCarModels.BMW)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "BMW Alpina")
            {
                foreach (var item in DatabaseCarModels.BMWAlpina)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Brilliance")
            {
                foreach (var item in DatabaseCarModels.Brilliance)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Buick")
            {
                foreach (var item in DatabaseCarModels.Buick)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "BYD")
            {
                foreach (var item in DatabaseCarModels.BYD)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Cadillac")
            {
                foreach (var item in DatabaseCarModels.Cadillac)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
        }
    }
}
