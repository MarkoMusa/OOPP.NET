using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace Zadatak_03
{
    public partial class Z03_Main : Form
    {
        public Z03_Main()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            BackColor = Util.GetRandomColor();
            Size = Util.GetRandomSize(200,800,200,800);
            if (sender.GetType() == typeof(Button))
            {
                Util.Center((Control)sender, this);
            }

            Location = Util.GetRandomLocation(this);
            
        }
    }
}
