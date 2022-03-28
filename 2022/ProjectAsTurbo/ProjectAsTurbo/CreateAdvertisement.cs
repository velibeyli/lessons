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
    }
}
