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
            if (comboBox_all_brands.SelectedItem == "Changan")
            {
                foreach (var item in DatabaseCarModels.Changan)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Chery")
            {
                foreach (var item in DatabaseCarModels.Chery)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Chevrolet")
            {
                foreach (var item in DatabaseCarModels.Chevrolet)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Chrysler")
            {
                foreach (var item in DatabaseCarModels.Chrysler)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Citroen")
            {
                foreach (var item in DatabaseCarModels.Citroen)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Dacia")
            {
                foreach (var item in DatabaseCarModels.Dacia)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Daewoo")
            {
                foreach (var item in DatabaseCarModels.Daewoo)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "DAF")
            {
                foreach (var item in DatabaseCarModels.DAF)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Daihatsu")
            {
                foreach (var item in DatabaseCarModels.Daihatsu)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Dayun")
            {
                foreach (var item in DatabaseCarModels.Dayun)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Dnepr")
            {
                foreach (var item in DatabaseCarModels.Dnepr)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Dodge")
            {
                foreach (var item in DatabaseCarModels.Dodge)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "DongFeng")
            {
                foreach (var item in DatabaseCarModels.DongFeng)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Ducati")
            {
                foreach (var item in DatabaseCarModels.Ducati)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "FAW")
            {
                foreach (var item in DatabaseCarModels.FAW)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Fiat")
            {
                foreach (var item in DatabaseCarModels.Fiat)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Ford")
            {
                foreach (var item in DatabaseCarModels.Ford)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Foton")
            {
                foreach (var item in DatabaseCarModels.Foton)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "GAC")
            {
                foreach (var item in DatabaseCarModels.GAC)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "GAZ")
            {
                foreach (var item in DatabaseCarModels.GAZ)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Geely")
            {
                foreach (var item in DatabaseCarModels.Geely)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Genesis")
            {
                foreach (var item in DatabaseCarModels.Genesis)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "GMC")
            {
                foreach (var item in DatabaseCarModels.GMC)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Great Wall")
            {
                foreach (var item in DatabaseCarModels.GreatWall)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if(comboBox_all_brands.SelectedItem == "Haima")
            {
                foreach (var item in DatabaseCarModels.Haima)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Haojue")
            {
                foreach (var item in DatabaseCarModels.Haojue)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Harley-Davidson")
            {
                foreach (var item in DatabaseCarModels.HarleyDavidson)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Harley-Davidson")
            {
                foreach (var item in DatabaseCarModels.HarleyDavidson)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Haval")
            {
                foreach (var item in DatabaseCarModels.Haval)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Honda")
            {
                foreach (var item in DatabaseCarModels.Honda)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Hongqi")
            {
                foreach (var item in DatabaseCarModels.Hongqi)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "HOWO")
            {
                foreach (var item in DatabaseCarModels.HOWO)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Hummer")
            {
                foreach (var item in DatabaseCarModels.Hummer)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Hyundai")
            {
                foreach (var item in DatabaseCarModels.Hyundai)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "IJ")
            {
                foreach (var item in DatabaseCarModels.IJ)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Infiniti")
            {
                foreach (var item in DatabaseCarModels.Infiniti)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Iran Khodro")
            {
                foreach (var item in DatabaseCarModels.IranKhodro)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Isuzu")
            {
                foreach (var item in DatabaseCarModels.Isuzu)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Iveco")
            {
                foreach (var item in DatabaseCarModels.Iveco)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "JAC")
            {
                foreach (var item in DatabaseCarModels.Jac)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Jaguar")
            {
                foreach (var item in DatabaseCarModels.Jaquar)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Jawa")
            {
                foreach (var item in DatabaseCarModels.Jawa)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Jeep")
            {
                foreach (var item in DatabaseCarModels.Jeep)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Jetour")
            {
                foreach (var item in DatabaseCarModels.Jetour)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Jinbei")
            {
                foreach (var item in DatabaseCarModels.Jinbei)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Jonway")
            {
                foreach (var item in DatabaseCarModels.Jonway)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "KamAz")
            {
                foreach (var item in DatabaseCarModels.KamAz)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "KAvZ")
            {
                foreach (var item in DatabaseCarModels.KAvZ)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Kawasaki")
            {
                foreach (var item in DatabaseCarModels.Kawasaki)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Khazar")
            {
                foreach (var item in DatabaseCarModels.Khazar)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Kia")
            {
                foreach (var item in DatabaseCarModels.Kia)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "KrAZ")
            {
                foreach (var item in DatabaseCarModels.KrAZ)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "KTM")
            {
                foreach (var item in DatabaseCarModels.KTM)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Kuba")
            {
                foreach (var item in DatabaseCarModels.Kuba)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "LADA (VAZ)")
            {
                foreach (var item in DatabaseCarModels.LADA_VAZ)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Lamborghini")
            {
                foreach (var item in DatabaseCarModels.Lamborghini)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Land Rover")
            {
                foreach (var item in DatabaseCarModels.LandRover)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Lexus")
            {
                foreach (var item in DatabaseCarModels.Lexus)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Lifan")
            {
                foreach (var item in DatabaseCarModels.Lifan)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Lincoln")
            {
                foreach (var item in DatabaseCarModels.Lincoln)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "LuAz")
            {
                foreach (var item in DatabaseCarModels.LuAz)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "MAN")
            {
                foreach (var item in DatabaseCarModels.MAN)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Maserati")
            {
                foreach (var item in DatabaseCarModels.Maserati)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "MAZ")
            {
                foreach (var item in DatabaseCarModels.MAZ)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Mazda")
            {
                foreach (var item in DatabaseCarModels.Mazda)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Mercedes")
            {
                foreach (var item in DatabaseCarModels.Mercedes)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Mercedes-Maybach")
            {
                foreach (var item in DatabaseCarModels.Mercedes_Maybach)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "MG")
            {
                foreach (var item in DatabaseCarModels.MG)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Mini")
            {
                foreach (var item in DatabaseCarModels.Mini)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Minsk")
            {
                foreach (var item in DatabaseCarModels.Minsk)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Mitsubishi")
            {
                foreach (var item in DatabaseCarModels.Mitsubishi)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Moskvich")
            {
                foreach (var item in DatabaseCarModels.Moskvich)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Muravey")
            {
                foreach (var item in DatabaseCarModels.Muravey)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Nama")
            {
                foreach (var item in DatabaseCarModels.Nama)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Neptun")
            {
                foreach (var item in DatabaseCarModels.Neptun)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Nissan")
            {
                foreach (var item in DatabaseCarModels.Nissan)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Opel")
            {
                foreach (var item in DatabaseCarModels.Opel)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Otocar")
            {
                foreach (var item in DatabaseCarModels.Otocar)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "PAZ")
            {
                foreach (var item in DatabaseCarModels.PAZ)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Peugeot")
            {
                foreach (var item in DatabaseCarModels.Peugeot)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Polaris")
            {
                foreach (var item in DatabaseCarModels.Polaris)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Porsche")
            {
                foreach (var item in DatabaseCarModels.Porsche)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Proton")
            {
                foreach (var item in DatabaseCarModels.Proton)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "RAF")
            {
                foreach (var item in DatabaseCarModels.RAF)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Ravon")
            {
                foreach (var item in DatabaseCarModels.Ravon)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Renault")
            {
                foreach (var item in DatabaseCarModels.Renault)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "RKS")
            {
                foreach (var item in DatabaseCarModels.RKS)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Rolls-Royce")
            {
                foreach (var item in DatabaseCarModels.Rolls_Royce)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Rover")
            {
                foreach (var item in DatabaseCarModels.Rover)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Saipa")
            {
                foreach (var item in DatabaseCarModels.Saipa)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Scania")
            {
                foreach (var item in DatabaseCarModels.Scania)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "SEAT")
            {
                foreach (var item in DatabaseCarModels.SEAT)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Setra")
            {
                foreach (var item in DatabaseCarModels.Setra)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Shacman")
            {
                foreach (var item in DatabaseCarModels.Shacman)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Skoda")
            {
                foreach (var item in DatabaseCarModels.Skoda)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Smart")
            {
                foreach (var item in DatabaseCarModels.Smart)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Ssang Yong")
            {
                foreach (var item in DatabaseCarModels.SsangYong)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Subaru")
            {
                foreach (var item in DatabaseCarModels.Subaru)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Suzuki")
            {
                foreach (var item in DatabaseCarModels.Suzuki)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Temsa")
            {
                foreach (var item in DatabaseCarModels.Temsa)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Tesla")
            {
                foreach (var item in DatabaseCarModels.Tesla)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Tofas")
            {
                foreach (var item in DatabaseCarModels.Tofas)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Toyota")
            {
                foreach (var item in DatabaseCarModels.Toyota)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Tufan")
            {
                foreach (var item in DatabaseCarModels.Tufan)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "UAZ")
            {
                foreach (var item in DatabaseCarModels.UAZ)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Ural")
            {
                foreach (var item in DatabaseCarModels.Ural)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Vespa")
            {
                foreach (var item in DatabaseCarModels.Vespa)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Volkswagen")
            {
                foreach (var item in DatabaseCarModels.Volkswagen)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Volvo")
            {
                foreach (var item in DatabaseCarModels.Volvo)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Yamaha")
            {
                foreach (var item in DatabaseCarModels.Yamaha)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "ZAZ")
            {
                foreach (var item in DatabaseCarModels.ZAZ)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "ZIL")
            {
                foreach (var item in DatabaseCarModels.ZIL)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Zongshen")
            {
                foreach (var item in DatabaseCarModels.Zongshen)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "Zontes")
            {
                foreach (var item in DatabaseCarModels.Zontes)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
            if (comboBox_all_brands.SelectedItem == "ZX Auto")
            {
                foreach (var item in DatabaseCarModels.ZXAuto)
                {
                    comboBox_all_models.Items.Add(item);
                }
            }
        }

    }
}
