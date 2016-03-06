using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak05
{
    public partial class frmZ05 : Form
    {
        public frmZ05()
        {
            InitializeComponent();
        }

        private void btnShowHideInTaskbar_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = !ShowInTaskbar;
            
            if (sender.GetType() == typeof(Button))
            {
                (sender as Button).Text = ShowInTaskbar ? "Hide from Taskbar" : "Show in taskbar";
            }
                 
        }

        private void btnTopToggle_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;
            if (sender.GetType() == typeof(Button))
            {
                (sender as Button).Text = TopMost ? "Disable topmost" : "Enable TopMost";
            }
        }
    }
}
