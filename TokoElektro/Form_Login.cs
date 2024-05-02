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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardAdmin admindashboard = new DashboardAdmin();
            admindashboard.Show();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
