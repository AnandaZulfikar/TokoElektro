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
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            InitializeComponent();
            panel1.Region = System.Drawing.Region.FromHrgn(Rounded.CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 12, 12));
            button_Logout.Region = System.Drawing.Region.FromHrgn(Rounded.CreateRoundRectRgn(0, 0, button_Logout.Width, button_Logout.Height, 10,10));
            button_home.Region = System.Drawing.Region.FromHrgn(Rounded.CreateRoundRectRgn(0, 0, button_home.Width, button_home.Height, 8, 8));
            button_barang.Region = System.Drawing.Region.FromHrgn(Rounded.CreateRoundRectRgn(0, 0, button_barang.Width, button_barang.Height, 8, 8));
            button_detailTransaksi.Region = System.Drawing.Region.FromHrgn(Rounded.CreateRoundRectRgn(0, 0, button_detailTransaksi.Width, button_detailTransaksi.Height, 8, 8));
            button_karyawan.Region = System.Drawing.Region.FromHrgn(Rounded.CreateRoundRectRgn(0, 0, button_karyawan.Width, button_karyawan.Height, 8, 8));

            ShowUserControl<Admin_Home>();
        }

        public void ShowUserControl<T>() where T : UserControl, new()
        {
            T userControl = this.Controls.OfType<T>().FirstOrDefault();
            if (userControl == null)
            {
                userControl = new T();
                userControl.Dock = DockStyle.Fill;
                this.Controls.Add(userControl);
            }
            userControl.BringToFront();
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            ShowUserControl<Admin_Home>();
        }

        private void button_barang_Click(object sender, EventArgs e)
        {
            ShowUserControl<Admin_Barang>();
        }

        private void button_detailTransaksi_Click(object sender, EventArgs e)
        {
            ShowUserControl<Admin_detailTransaksi>();
        }

        private void button_karyawan_Click(object sender, EventArgs e)
        {
            ShowUserControl<Admin_Karyawan>();
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Login panggil = new Form_Login();
            panggil.Show();
        }
    }
}
