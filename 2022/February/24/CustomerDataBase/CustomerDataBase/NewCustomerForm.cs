using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerDataBase
{
    public partial class NewCustomerForm : Form
    {
        public NewCustomerForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            if (textBoxName.Text != null || textBoxSurname.Text != null || textBoxGender.Text != null || textBoxCountry.Text != null ||
                textBoxCity.Text != null || textBoxAdress.Text != null || textBoxPhone.Text != null || textBoxEmail.Text != null)
            {
                customer.Name = textBoxName.Text;
                customer.Surname = textBoxSurname.Text;
                customer.Gender = textBoxGender.Text;
                customer.Country = textBoxCountry.Text;
                customer.City = textBoxCity.Text;
                customer.Address = textBoxAdress.Text;
                customer.Phone = textBoxPhone.Text;
                customer.Email = textBoxEmail.Text;

                VirtualDataBase.CustomerInfo.Add(customer);
                this.Close();
               

            }
        }
    }
}
