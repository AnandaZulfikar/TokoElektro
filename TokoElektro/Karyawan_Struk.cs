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
    public partial class Karyawan_Struk : UserControl
    {
        public Karyawan_Struk()
        {
            InitializeComponent();
            button_tambah.Region = System.Drawing.Region.FromHrgn(Rounded.CreateRoundRectRgn(0, 0, button_tambah.Width, button_tambah.Height, 20, 20));
            button_detail.Region = System.Drawing.Region.FromHrgn(Rounded.CreateRoundRectRgn(0, 0, button_detail.Width, button_detail.Height, 20, 20));

        }
    }
}
