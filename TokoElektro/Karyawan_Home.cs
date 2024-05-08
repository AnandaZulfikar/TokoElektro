using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokoElektro
{
    public partial class Karyawan_Home : UserControl
    {
        public Karyawan_Home()
        {
            InitializeComponent();
            panel1.Region = System.Drawing.Region.FromHrgn(Rounded.CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            panel2.Region = System.Drawing.Region.FromHrgn(Rounded.CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 20, 20));
            panel5.Region = System.Drawing.Region.FromHrgn(Rounded.CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 20, 20));

        }
    }
}
