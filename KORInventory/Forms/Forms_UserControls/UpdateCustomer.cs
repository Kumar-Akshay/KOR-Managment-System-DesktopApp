using KORDAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KORInventory.Forms.Forms_UserControls
{
    public partial class UpdateCustomer : UserControl
    {
        public UpdateCustomer()
        {
            InitializeComponent();
            Refreshdata();
            nLabel.Visible = false;
            nametb.Visible = false;
            addresstb.Visible = false;
            aLabel.Visible = false;
            phonetb.Visible = false;
            pLabel.Visible = false;
        }

        public void Refreshdata()
        {
            using var dbContext = new KORInventoryDBContext();
            var customers = dbContext.Customer.Select(p => p.Name).ToList();
            cmbCustomer.ValueMember = "Name";
            cmbCustomer.DisplayMember = "Select Customer";
            if (customers.Count != 0)
            {
                cmbCustomer.DataSource = customers;
            }
        }
        private void CmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            nLabel.Visible = true;
            nametb.Visible = true;
            addresstb.Visible = true;
            aLabel.Visible = true;
            phonetb.Visible = true;
            pLabel.Visible = true;
            var selectedName = cmbCustomer.SelectedItem.ToString();
            using var dbContext = new KORInventoryDBContext();
            var customer = dbContext.Customer.Where(p => p.Name.ToLower() == selectedName.ToLower()).FirstOrDefault();
            if(customer != null)
            {
                nametb.Text = customer.Name;
                addresstb.Text = customer.Address;
                phonetb.Text = customer.PhoneNumber;
            }
        }
    }
}
