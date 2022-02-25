﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace WindowsFormsAppPart6
{
    public partial class DataGridViewForm : Form
    {
        public DataGridViewForm()
        {
            InitializeComponent();
        }

        private void DataGridViewForm_Load(object sender, EventArgs e)
        {
            VirtualDatabase db = new VirtualDatabase();
            List<Customer> customers = db.GetCustomers(100);

            customersDataGridView.DataSource = customers;
            customersDataGridView.Columns[0].Width = 25;
            customersDataGridView.Columns["Name"].HeaderText = "Ad";
            //customersDataGridView.Columns["Fullname"].Visible = false;

            //Linq select 1-ci yol
            var queryResult = (from item in customers
                               select new
                               {
                                   Sira = item.Id,
                                   Ad = item.Name,
                                   Soyad = item.Surname
                               }).ToList();

            //Linq select 2-ci yol method ile.
            var queryResult2 = customers.Select(item => new
            {
                Sira = item.Id,
                Ad = item.Name,
                Soyad = item.Surname
            }).ToList();

            customersDataGridView.DataSource = queryResult2;

            //customersDataGridView.DataSource = customers;
        }

        private void customersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = customersDataGridView.CurrentCell.RowIndex;
            int customerId = (int)customersDataGridView[0, rowIndex].Value;
            //MessageBox.Show(customerId.ToString());

            VirtualDatabase db = new VirtualDatabase();
            Customer selectedCustomer = db.GetCustomers(100).FindAll(i => i.Id == customerId).FirstOrDefault();

            /*
             Müştərinin məlumatlarını popup kimi açılan bir form içərisində göstərin. Ancaq Form'un FormBorderStyle property'si None olmalıdır Form'un bu property dəyəri
             none olduğuna görə artıq user onu bağlaya bilməyəcək. İndi həm yeni bir popup pəncərəsində seçilən müştəri məlumatları göstərilməlidir həm də user o form'u
             necəsə bağlaya bilməlidir (ALT + F4 ilə bağlasın deməyin :)) biraz düşünün). Məlumatları sadəcə Label elementi içərisində göstərmək kifayət edər.
             */

            CustomerInfoPupup infoPopup = new CustomerInfoPupup(selectedCustomer, this); //(constructor method'a Customer tipində parametr əlavə et)
            infoPopup.ShowDialog();
        }
    }
}
