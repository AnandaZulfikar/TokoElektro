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
            Admin_Home admin_home = this.Controls.OfType<Admin_Home>().FirstOrDefault();
            if (admin_home == null)
            {
                admin_home = new Admin_Home();
                admin_home.Dock = DockStyle.Fill;
                this.Controls.Add(admin_home);
            }
            admin_home.BringToFront();
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            Admin_Home admin_home = this.Controls.OfType<Admin_Home>().FirstOrDefault();
            if(admin_home == null)
            {
                admin_home = new Admin_Home();
                admin_home.Dock = DockStyle.Fill;
                this.Controls.Add(admin_home);
            }
            admin_home.BringToFront();
        }

        private void button_barang_Click(object sender, EventArgs e)
        {
            Admin_Barang admin_barang = this.Controls.OfType<Admin_Barang>().FirstOrDefault();
            if(admin_barang == null)
            {
                admin_barang = new Admin_Barang();
                admin_barang.Dock = DockStyle.Fill;
                this.Controls.Add(admin_barang);
            }
            admin_barang.BringToFront();
        }

        private void button_detailTransaksi_Click(object sender, EventArgs e)
        {
            Admin_detailTransaksi admin_detail_transaksi = this.Controls.OfType<Admin_detailTransaksi>().FirstOrDefault();
            if(admin_detail_transaksi == null)
            {
                admin_detail_transaksi = new Admin_detailTransaksi();
                admin_detail_transaksi.Dock = DockStyle.Fill;
                this.Controls.Add(admin_detail_transaksi);
            }
            admin_detail_transaksi.BringToFront();
        }

        private void button_karyawan_Click(object sender, EventArgs e)
        {
            Admin_Karyawan admin_karyawan = this.Controls.OfType<Admin_Karyawan>().FirstOrDefault();
            if(admin_karyawan == null)
            {
                admin_karyawan = new Admin_Karyawan();
                admin_karyawan.Dock = DockStyle.Fill;
                this.Controls.Add(admin_karyawan);
            }
            admin_karyawan.BringToFront();
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Login panggil = new Form_Login();
            panggil.Show();
        }
    }
}
