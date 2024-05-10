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
    public partial class Karyawan_Transaksi_Add_Pay : UserControl, IAcceptParameters
    {
        public SqlConnection connection = new SqlConnection(dbconfig.conn);
        public SqlCommand command;
        private int idstruk,total;
        public Karyawan_Transaksi_Add_Pay()
        {
            InitializeComponent();
        }
        public void ShowUserControl<T>(params object[] parameters) where T : UserControl, new()
        {
            T userControl = this.Controls.OfType<T>().FirstOrDefault();
            if (userControl == null)
            {
                userControl = new T();
                userControl.Dock = DockStyle.Fill;
                this.Controls.Add(userControl);
            }

            // Cek apakah user control memiliki metode SetParameters
            if (userControl is IAcceptParameters)
            {
                // Panggil metode SetParameters untuk meneruskan semua parameter
                (userControl as IAcceptParameters).SetParameters(parameters);
            }
            userControl.Show();
            userControl.BringToFront();
        }

        private void button_kembali_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_proses_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_nominal_bayar.Text))
            {
                int bayar = Convert.ToInt32(textBox_nominal_bayar.Text);

                if (bayar < total)
                {
                    MessageBox.Show("Uangnya kurang");
                    return;
                }
                else
                {
                    try
                    {
                        // Perbarui data struk dengan nilai bayar yang baru
                        connection.Open();
                        string queryUpdateStruk = $"UPDATE struk SET bayar = {bayar}, kembali = {bayar - total} WHERE id = {idstruk}";
                        SqlCommand commandUpdateStruk = new SqlCommand(queryUpdateStruk, connection);
                        commandUpdateStruk.ExecuteNonQuery();

                        MessageBox.Show("Transaksi berhasil diproses");
                        ShowUserControl<Karyawan_Struk>();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Silakan masukkan nominal pembayaran");
            }
        }

        private void button_uang_pas_Click(object sender, EventArgs e)
        {
            textBox_nominal_bayar.Text = total.ToString();
        }

        private void button_uang_50k_Click(object sender, EventArgs e)
        {
            textBox_nominal_bayar.Text = "50000";
        }

        private void button_uang_100k_Click(object sender, EventArgs e)
        {
            textBox_nominal_bayar.Text = "100000";
        }

        private void button_uang_200k_Click(object sender, EventArgs e)
        {
            textBox_nominal_bayar.Text = "200000";
        }

        public void SetParameters(params object[] parameters)
        {
            idstruk = Convert.ToInt32(parameters[0].ToString());
            total = Convert.ToInt32(parameters[1].ToString());
            label_total.Text = $"Total : {total.ToString("C", new CultureInfo("id-ID"))}";
        }
    }
}
