using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilities
{
    public static class Util
    {
        private static Random rnd = new Random();

        public static Color GetRandomColor()
        {
            return Color.FromArgb(
                        rnd.Next(255), 
                        rnd.Next(255), 
                        rnd.Next(255)
                    );
        }

        public static Size GetRandomSize(int minWidth, int maxWidth, int minHight, int maxHight)
        {
            return new Size(
                       rnd.Next(minWidth, maxWidth), 
                       rnd.Next(minHight, maxWidth)
                    );
        }

        public static Point GetRandomLocation(Control child, Control parent)
        {
            int maxX = parent.Width - child.Width;
            int maxY = parent.Height - child.Height;

            return new Point(rnd.Next(0, maxX), rnd.Next(0, maxY));
        }

        public static Point GetRandomLocation(Control c)
        {
            Rectangle screen = Screen.GetBounds(c);
            int maxX = screen.Width - c.Width;
            int maxY = screen.Height - c.Height;

            return new Point(rnd.Next(0, maxX), rnd.Next(0, maxY));
        }

        public static void Center(Control b, Control f)
        {
            b.Location = new Point(
                        (f.ClientSize.Width - b.Width) / 2,
                        (f.ClientSize.Height - b.Height) / 2
                    );
        }
    }
}
