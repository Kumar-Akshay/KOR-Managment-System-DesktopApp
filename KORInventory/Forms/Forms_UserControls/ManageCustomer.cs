using KORDAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KORInventory.Forms.Forms_UserControls
{
    public partial class ManageCustomer : UserControl
    {
        public ManageCustomer(Panel Content)
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var AddCustomerControl = new AddCustomer();
            MainUserControl.ShowControl(AddCustomerControl, CustomerPanel);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            var UpdateCustomerControl = new UpdateCustomer();
            MainUserControl.ShowControl(UpdateCustomerControl, CustomerPanel);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var DeleteCustomerControl = new DeleteCustomer();
            MainUserControl.ShowControl(DeleteCustomerControl, CustomerPanel);
        }
    }
}
