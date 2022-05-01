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
using System.Windows.Forms;

namespace KORInventory.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.FormClosing += LoginForm_FormClosing;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = tbUsername.Text.ToString();
            string password = tbPassword.Text.ToString();
            if (string.IsNullOrEmpty(tbUsername.Text.ToString()) && string.IsNullOrEmpty(tbPassword.Text.ToString()))
            {
                MessageBox.Show("Username and Password Can't be empty, try again.");
                return;
            }
            using var dbContext = new KORInventoryDBContext();
            var user = await dbContext.User.Where(p => p.Username.ToLower() == userName && p.Password == password).FirstOrDefaultAsync(); 
            if(user != null)
            {
                // redirect to dashboard
                this.Hide();
                DashboardForm dashboard = new DashboardForm();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Username and Password are incorret, try again.");
                return;
            }     
        }

        private void LoginForm_FormClosing(Object sender, FormClosingEventArgs e)
        {
            //In case windows is trying to shut down, don't hold the process up
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            if (this.DialogResult == DialogResult.None)
            {
                // Assume that X has been clicked and act accordingly.
                // Confirm user wants to close
                var check = MessageBox.Show(this, "Are you sure to close it.?", "Do you still want ... ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (check)
                {
                    //Stay on this form
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    case DialogResult.Yes:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }


    }
}
