using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokoElektro
{
    public partial class Karyawan_Struk : UserControl
    {
        public SqlConnection connection = new SqlConnection(dbconfig.conn);
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataTable tabel;
        public SqlDataReader reader;

        public Karyawan_Struk()
        {
            InitializeComponent();
            button_tambah.Region = System.Drawing.Region.FromHrgn(Rounded.CreateRoundRectRgn(0, 0, button_tambah.Width, button_tambah.Height, 20, 20));
            button_detail.Region = System.Drawing.Region.FromHrgn(Rounded.CreateRoundRectRgn(0, 0, button_detail.Width, button_detail.Height, 20, 20));
            label3.Text = Convert.ToString(GlobalVar.karyawan_id);
            showStruk();
        }

        // func
        public void ShowUserControl<T>(int id_struk = -1) where T : UserControl, new()
        {
            T userControl = this.Controls.OfType<T>().FirstOrDefault();
            if (userControl == null)
            {
                userControl = new T();
                userControl.Dock = DockStyle.Fill;
                this.Controls.Add(userControl);
            }

            // Cek apakah user control memiliki metode SetIdStruk
            if (userControl is IAcceptIdStruk && id_struk != -1)
            {
                // Panggil metode SetIdStruk untuk meneruskan id_struk
                (userControl as IAcceptIdStruk).SetIdStruk(id_struk);
            }

            userControl.Show();
            userControl.BringToFront();
        }

        public void createStruk()
        {
            try {
                connection.Close();
                connection.Open();

                string sql = $"INSERT INTO struk (id_karyawan, tanggal) VALUES" +
                    $"('{GlobalVar.karyawan_id}', GETDATE());" +
                    $"SELECT SCOPE_IDENTITY();";
                SqlCommand command = new SqlCommand(sql, connection);

                int id_struk = Convert.ToInt32(command.ExecuteScalar());
                GlobalVar.temp_struk_id = id_struk;

                ShowUserControl<Karyawan_Transaksi_Add>(id_struk);
                connection.Close();
            } 
            catch(Exception e) {
                connection.Close();
                MessageBox.Show(e.Message);
            }
        }
        
        public void showStruk()
        {
            try
            {
                connection.Close();
                connection.Open();

                string query = "SELECT * FROM struk";

                command = new SqlCommand(query, connection);
                adapter = new SqlDataAdapter(command);
                tabel = new DataTable();
                adapter.Fill(tabel);

                table_struk.DataSource = tabel;
                table_struk.Columns[0].HeaderText = "ID";
                table_struk.Columns[1].HeaderText = "ID Karyawan";
                table_struk.Columns[2].HeaderText = "tanggal";
                table_struk.Columns[3].HeaderText = "total";
                table_struk.Columns[4].HeaderText = "bayar";
                table_struk.Columns[5].HeaderText = "kembali";

                connection.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error at:" + x);
            }
        }
        // end func

        private void button_tambah_Click(object sender, EventArgs e)
        {
            createStruk();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            showStruk();
        }
    }
}
