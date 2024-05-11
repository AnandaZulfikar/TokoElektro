using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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
            panel5.Region = System.Drawing.Region.FromHrgn(Rounded.CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 20, 20));
            showTotal();
        }

        public void showTotal()
        {
            try
            {
                string queryTotalBarang = "SELECT COUNT(*) FROM barang";
                int totalBarang = 0;

                using (SqlConnection connection = new SqlConnection(dbconfig.conn))
                {
                    using (SqlCommand command = new SqlCommand(queryTotalBarang, connection))
                    {
                        connection.Open();
                        totalBarang = (int)command.ExecuteScalar();
                    }
                }

                string queryTotalTransaksi = "SELECT COUNT(*) FROM struk WHERE bayar > 0";
                int totalTransaksi = 0;

                using (SqlConnection connection = new SqlConnection(dbconfig.conn))
                {
                    using (SqlCommand command = new SqlCommand(queryTotalTransaksi, connection))
                    {
                        connection.Open();
                        totalTransaksi = (int)command.ExecuteScalar();
                    }
                }

                label_total_barang.Text = totalBarang.ToString();
                label_total_struk.Text = totalTransaksi.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

    }
}
