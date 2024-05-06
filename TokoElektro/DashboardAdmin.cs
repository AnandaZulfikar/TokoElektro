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
