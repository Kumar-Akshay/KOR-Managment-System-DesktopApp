using KORDAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KORInventory.Forms.Forms_UserControls
{
    public partial class DeleteCustomer : UserControl
    {
        public DeleteCustomer()
        {
            InitializeComponent();
            Refreshdata();
        }
        public void Refreshdata()
        {
            using var dbContext = new KORInventoryDBContext();
            var customers = dbContext.Customer.Select(p => p.Name).ToList();
            cmbCustomerDelete.ValueMember = "Name";
            cmbCustomerDelete.DisplayMember = "Select Customer";
            if (customers.Count != 0)
            {
                cmbCustomerDelete.DataSource = customers;
            }
        }
        private void cmbCustomerDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedName = cmbCustomerDelete.SelectedItem.ToString();
            using var dbContext = new KORInventoryDBContext();
            var customer = dbContext.Customer.Where(p => p.Name.ToLower() == selectedName.ToLower()).FirstOrDefault();
            if (customer != null)
            {
                nLabel.Visible = true;
                showname.Visible = true;
                showaddress.Visible = true;
                aLabel.Visible = true;
                showphone.Visible = true;

                showname.Text = customer.Name;
                showaddress.Text = customer.Address;
                showphone.Text = customer.PhoneNumber;
            }
        }
    }
}
