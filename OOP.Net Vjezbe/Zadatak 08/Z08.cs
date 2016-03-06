using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace Zadatak_08
{
    public partial class Form1 : Form
    {
        private const int PANEL_WIDTH = 100;
        private const int PANEL_HEIGHT = 100;
        private Panel lastAddedPanel = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenForm_Click(object sender, EventArgs e)
        {
            lastAddedPanel = RandomPanelGenerator();
            Controls.Add(lastAddedPanel);
        }

        private Panel RandomPanelGenerator()
        {
            Panel p = new Panel();
            p.BackColor = Util.GetRandomColor();
            p.Location = Util.GetRandomLocation(p, this);
            p.Size = new Size(PANEL_WIDTH, PANEL_HEIGHT);

            return p;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (lastAddedPanel != null)
            {
                lastAddedPanel.Location = new Point(lastAddedPanel.Location.X + 10, lastAddedPanel.Location.Y);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Loading
            if (!File.Exists("blah.txt")) return;
            try
            {
                // xxx: delimiter and fn need to be constants and abstract
                using (StreamReader sr = new StreamReader("blah.txt"))
                {
                    string line = sr.ReadLine();
                    while(line != null)
                    {
                        string[] tmp = line.Split('|');

                        int x = int.Parse(tmp[0]);
                        int y = int.Parse(tmp[1]);
                        
                        // TODO: add RGB and show panel

                        line = sr.ReadLine();
                    }
                }
            }
            catch (Exception x)
            {

                MessageBox.Show(x.ToString());
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                // xxx: delimiter and fn need to be constants and abstract
                using(StreamWriter sr = new StreamWriter("blah.txt"))
                {
                    foreach(Control c in this.Controls)
                    {
                        if (c is Panel)
                        {
                            sr.WriteLine("{0}|{1}", c.Location.X, c.Location.Y);
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
