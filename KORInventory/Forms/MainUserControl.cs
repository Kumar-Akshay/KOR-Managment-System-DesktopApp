using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace KORInventory.Forms
{
    public class MainUserControl
    {
        public static void ShowControl(Control control, Control content)
        {
            content.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            content.Controls.Add(control);
        }
    }
}
