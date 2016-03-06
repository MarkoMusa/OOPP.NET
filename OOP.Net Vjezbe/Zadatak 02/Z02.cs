using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak_02
{
    public partial class Z01_Main : Form
    {
        public Z01_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm(new Form_150x150_Static());
        }

        private void btnRedFormOpen_Click(object sender, EventArgs e)
        {
            OpenForm(new Form_100x100_Red());
        }

        private void btnControlFalseForm_Click(object sender, EventArgs e)
        {
            OpenForm(new Form_200x200());
        }

        private void OpenForm(Form f)
        {
            f.Show();
        }
    }
}
