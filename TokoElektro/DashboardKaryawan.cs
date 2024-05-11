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
    public partial class DashboardKaryawan : Form
    {
        public DashboardKaryawan()
        {
            InitializeComponent();
            panel1.Region = System.Drawing.Region.FromHrgn(Rounded.CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 12, 12));
            button_Logout.Region = System.Drawing.Region.FromHrgn(Rounded.CreateRoundRectRgn(0, 0, button_Logout.Width, button_Logout.Height, 10, 10));
            button_home.Region = System.Drawing.Region.FromHrgn(Rounded.CreateRoundRectRgn(0, 0, button_home.Width, button_home.Height, 8, 8));
            button_barang.Region = System.Drawing.Region.FromHrgn(Rounded.CreateRoundRectRgn(0, 0, button_barang.Width, button_barang.Height, 8, 8));
            button_struk.Region = System.Drawing.Region.FromHrgn(Rounded.CreateRoundRectRgn(0, 0, button_struk.Width, button_struk.Height, 8, 8));

            ShowUserControl<Karyawan_Home>();
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

        private void button_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Login panggil = new Form_Login();
            panggil.Show();
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            ShowUserControl<Karyawan_Home>();
        }

        private void button_barang_Click(object sender, EventArgs e)
        {
            ShowUserControl<Karyawan_Barang>();
        }

        private void button_struk_Click(object sender, EventArgs e)
        {
            ShowUserControl<Karyawan_Struk>();
        }
    }
}
