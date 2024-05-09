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
    public partial class Karyawan_Transaksi : UserControl
    {
        public Karyawan_Transaksi()
        {
            InitializeComponent();
            button_update.Region = System.Drawing.Region.FromHrgn(Rounded.CreateRoundRectRgn(0, 0, button_update.Width, button_update.Height, 20, 20));
            button_simpan.Region = System.Drawing.Region.FromHrgn(Rounded.CreateRoundRectRgn(0, 0, button_simpan.Width, button_simpan.Height, 20, 20));
            button_hapus.Region = System.Drawing.Region.FromHrgn(Rounded.CreateRoundRectRgn(0, 0, button_hapus.Width, button_hapus.Height, 20, 20));

        }
    }
}
