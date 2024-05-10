using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TokoElektro
{
    public partial class Karyawan_Transaksi_Add : UserControl, IAcceptIdStruk
    {
        public SqlConnection connection = new SqlConnection(dbconfig.conn);
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataTable tabel;
        public SqlDataReader reader;
        public string sql;
        public int subtotal = 0;
        private int idstruk;
        public Karyawan_Transaksi_Add()
        {
            InitializeComponent();
            FillComboBox();
            showData();

            //hide button
            button_hapus.Visible = false;
            button_bayar.Visible = false;
        }
        public void SetIdStruk(int id_struk)
        {
            idstruk = id_struk;
            label_test_id_struk.Text = $"Struk ID : {Convert.ToString(idstruk)}";
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


        private void FillComboBox()
        {
            using (SqlConnection connection = new SqlConnection(dbconfig.conn))
            {
                connection.Close();
                connection.Open();

                string query = "SELECT * FROM barang";

                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ada.Fill(ds);
                cmd.ExecuteNonQuery();
                connection.Close();

                comboBox_barang.DataSource = ds.Tables[0];
                comboBox_barang.DisplayMember = "nama";
                comboBox_barang.ValueMember = "id";
            }
        }

        private void showData()
        {
            try
            {
                connection.Close();
                connection.Open();

                string query = $"SELECT * FROM transaksi " +
                    $"JOIN barang ON transaksi.id_barang = barang.id " +
                    $"WHERE id_struk = {idstruk}";

                command = new SqlCommand(query, connection);
                adapter = new SqlDataAdapter(command);
                tabel = new DataTable();
                adapter.Fill(tabel);

                foreach (DataRow row in tabel.Rows)
                {
                    // Menambahkan nilai kolom keempat dari setiap baris ke subtotal
                    subtotal += Convert.ToInt32(row[4]);
                    label_subtotal.Text = $"Subtotal : {subtotal.ToString()}";
                }

                table_keranjang.DataSource = tabel;
                table_keranjang.Columns[0].Visible = false;
                table_keranjang.Columns[1].Visible = false;
                table_keranjang.Columns[2].Visible = false;
                table_keranjang.Columns[3].Visible = false;
                table_keranjang.Columns[4].Visible = false;
                table_keranjang.Columns[5].Visible = false;
                table_keranjang.Columns[6].HeaderText = "Nama Barang";
                table_keranjang.Columns[7].Visible = false;
                table_keranjang.Columns[8].HeaderText = "Harga";

                connection.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error at:" + x);
            }
        }

        private void tambah_barang()
        {
            if (comboBox_barang.SelectedIndex != -1 && !string.IsNullOrEmpty(textBox_qty.Text))
            {
                try
                {
                    connection.Open();

                    // Ambil harga barang dari database
                    string queryHarga = $"SELECT harga FROM barang WHERE id = '{comboBox_barang.SelectedValue}'";
                    SqlCommand commandHarga = new SqlCommand(queryHarga, connection);
                    int harga = Convert.ToInt32(commandHarga.ExecuteScalar());

                    // Hitung subtotal
                    int quantity = Convert.ToInt32(textBox_qty.Text);
                    int subtotal = harga * quantity;

                    // Masukkan data ke tabel transaksi
                    string queryInsert = $"INSERT INTO transaksi (id_barang, id_struk, quantity, sub_total) " +
                                          $"VALUES ('{comboBox_barang.SelectedValue}', " +
                                          $"'{idstruk}', " +
                                          $"'{quantity}', " +
                                          $"'{subtotal}')";
                    SqlCommand commandInsert = new SqlCommand(queryInsert, connection);
                    commandInsert.ExecuteNonQuery();

                    // Perbarui total harga pada tabel struk
                    string queryUpdateStruk = $"UPDATE struk SET total = (SELECT SUM(sub_total) FROM transaksi WHERE id_struk = '{idstruk}') " +
                                              $"WHERE id = '{idstruk}'";
                    SqlCommand commandUpdateStruk = new SqlCommand(queryUpdateStruk, connection);
                    commandUpdateStruk.ExecuteNonQuery();

                    MessageBox.Show("Data barang berhasil ditambahkan ke keranjang");
                    showData();
                }
                catch (Exception x)
                {
                    MessageBox.Show("Error: " + x.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Semua kolom tidak boleh kosong!");
            }
        }


        private void hapus_barang()
        {
            if (table_keranjang.CurrentRow.Selected)
            {
                DialogResult result = MessageBox.Show("Apakah yakin untuk menghapusnya dari keranjang?", "Confirmation", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    sql = "delete from transaksi where id = " + Convert.ToInt32(table_keranjang.CurrentRow.Cells[0].Value); ;
                    command = new SqlCommand(sql, connection);

                    try
                    {
                        connection.Close();
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Barang barang berhasil terdelete");
                        showData();
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("Error at : " + x);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih barang terlebih dahulu!");
            }
        }

        private void button_tambah_Click(object sender, EventArgs e)
        {
            tambah_barang();
        }

        private void table_keranjang_SelectionChanged(object sender, EventArgs e)
        {
            if (table_keranjang.SelectedRows.Count > 0)
            {
                // Jika ada baris yang dipilih
                button_hapus.Visible = true;
            }
            else
            {
                button_hapus.Visible = false;
            }
        }

        private void button_hapus_Click(object sender, EventArgs e)
        {
            hapus_barang();
        }

        private void button_selesai_Click(object sender, EventArgs e)
        {
            idstruk = 0;
            this.Hide();
        }

        private void table_keranjang_DataSourceChanged(object sender, EventArgs e)
        {
            CheckTableContent();
        }
        private void CheckTableContent()
        {
            if (table_keranjang.Rows.Count > 0)
            {
                // Jika tabel memiliki isian, tampilkan tombol "Selesai"
                button_bayar.Visible = true;
            }
            else
            {
                // Jika tabel tidak memiliki isian, sembunyikan tombol "Selesai"
                button_bayar.Visible = false;
            }
        }

        private void button_bayar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowUserControl<Karyawan_Transaksi_Add_Pay>(idstruk, subtotal);
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            FillComboBox();
        }
    }
}
