using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CustomerDataBase
{
    public partial class CustomerApp : Form
    {
        public CustomerApp()
        {
            InitializeComponent();
        }

        private void CustomerApp_Load(object sender, EventArgs e)
        {
            fillFullInformation();
        }
        public void fillFullInformation()
        {
            foreach (var item in VirtualDataBase.CustomerInfo)
            {
                comboBoxChoose.Items.Add(item);
            }
        }

        private void comboBoxChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer customer;

            var selectedCustomer = comboBoxChoose.SelectedItem;
            customer = (Customer)selectedCustomer;

            customer = comboBoxChoose.SelectedItem == null ? null : comboBoxChoose.SelectedItem as Customer;

            textBoxId.Text = customer.Id.ToString();
            textBoxName.Text = customer.Name;
            textBoxSurname.Text = customer.Surname;
            textBoxGender.Text = customer.Gender;
            textBoxCountry.Text = customer.Country;
            textBoxCity.Text = customer.City;
            textBoxAdress.Text = customer.Address;
            textBoxPhone.Text = customer.Phone;
            textBoxEmail.Text = customer.Email;


        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var customer = (Customer)comboBoxChoose.SelectedItem;

            customer = comboBoxChoose.SelectedItem == null ? null : comboBoxChoose.SelectedItem as Customer;

            if (comboBoxChoose.SelectedItem == null)
            {
                customer = null;
            }
            else
            {
                customer = (Customer)comboBoxChoose.SelectedItem;
            }

            


            if (textBoxName.Text != customer.Name || textBoxSurname.Text != customer.Surname || textBoxGender.Text != customer.Gender ||
               textBoxCountry.Text != customer.Country || textBoxCity.Text != customer.City || textBoxAdress.Text != customer.Address ||
               textBoxPhone.Text != customer.Phone || textBoxEmail.Text != customer.Email )
            {
                customer.Name = textBoxName.Text;
                customer.Surname = textBoxSurname.Text;
                customer.Gender = textBoxGender.Text;
                customer.Country = textBoxCountry.Text;
                customer.City = textBoxCity.Text;
                customer.Address = textBoxAdress.Text;
                customer.Phone = textBoxPhone.Text;
                customer.Email = textBoxEmail.Text;



                MessageBox.Show("Dəyişikliklər yeniləndi!","Bildiriş",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Heç bir deyişiklik qeydə alınmadı!", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var customer = (Customer)comboBoxChoose.SelectedItem;

            customer = comboBoxChoose.SelectedItem == null ? null : comboBoxChoose.SelectedItem as Customer;

            DialogResult result =  MessageBox.Show("Məlumatların silinməsindən əminsiniz", "Sual", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                comboBoxChoose.Items.Remove(comboBoxChoose.SelectedItem);
            }            
        }

        private void buttonNewCstmr_Click(object sender, EventArgs e)
        {
            NewCustomerForm newCustomer = new NewCustomerForm();
            newCustomer.Show();
            
        }

        
        
    }
}
