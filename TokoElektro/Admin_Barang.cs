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

namespace TokoElektro
{
    public partial class Admin_Barang : UserControl
    {
        public SqlConnection connection = new SqlConnection(dbconfig.conn);
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataTable tabel;
        public SqlDataReader reader;
        public string sql;
        public int id;
        public Admin_Barang()
        {
            InitializeComponent();
            button_update.Region = System.Drawing.Region.FromHrgn(Rounded.CreateRoundRectRgn(0, 0, button_update.Width, button_update.Height, 20, 20));
            button_tambah.Region = System.Drawing.Region.FromHrgn(Rounded.CreateRoundRectRgn(0, 0, button_tambah.Width, button_tambah.Height, 20, 20));
            button_hapus.Region = System.Drawing.Region.FromHrgn(Rounded.CreateRoundRectRgn(0, 0, button_hapus.Width, button_hapus.Height, 20, 20));

            showData();
        }

        public void showData()
        {
            try
            {
                connection.Close();
                connection.Open();

                string sql = "select * from barang";
                command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);
                tabel = new DataTable();
                adapter.Fill(tabel);

                dataGridView1.DataSource = tabel;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Nama Barang";
                dataGridView1.Columns[2].HeaderText = "Stok";
                dataGridView1.Columns[3].HeaderText = "Harga";

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at:" + ex);
            }
        }

        public void clear()
        {
            txtNamaBarang.Text = "";
            txtStok.Text = "";
            txtHarga.Text = "";
        }

        public void insertData()
        {
            if (!string.IsNullOrEmpty(txtNamaBarang.Text) && !string.IsNullOrEmpty(txtStok.Text) &&
                !string.IsNullOrEmpty(txtHarga.Text)) 
            {
                sql = "insert into barang (nama,stok,harga) values " +
                    "(@nama, @stok, @harga)";

                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@nama", txtNamaBarang.Text);
                command.Parameters.AddWithValue("@stok", txtStok.Text);
                command.Parameters.AddWithValue("@harga", txtHarga.Text);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data barang berhasil ditambahkan!");
                    clear();
                    showData();
                }
                catch (Exception x)
                {
                    MessageBox.Show("Error at:" + x);
                }
            }
            else
            {
                MessageBox.Show("Semua kolom tidak boleh kosong!");
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;

            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            txtNamaBarang.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtStok.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtHarga.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        public void updateData()
        {
            if (dataGridView1.CurrentRow.Selected)
            {
                if (!string.IsNullOrEmpty(txtNamaBarang.Text) && !string.IsNullOrEmpty(txtStok.Text) &&
                    !string.IsNullOrEmpty(txtHarga.Text))
                {
                    DialogResult result = MessageBox.Show("Apakah yakin ingin update data?", "Confirmation", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (result == DialogResult .Yes)
                    {
                        sql = "update barang set nama = @nama, stok = @stok, harga = @harga where id = " + id;

                        command = new SqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@nama", txtNamaBarang.Text);
                        command.Parameters.AddWithValue("@stok", txtStok.Text);
                        command.Parameters.AddWithValue("@harga", txtHarga.Text);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Data barang berhasil diupdate!");
                            clear();
                            showData();
                        }
                        catch (Exception x)
                        {
                            MessageBox.Show("Error at:" + x);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Semua kolom tidak boleh kosong!");
                }
            }
            else
            {
                MessageBox.Show("Tolong pilih data terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void deleteData()
        {
            if (dataGridView1.CurrentRow.Selected)
            {
                if (!string.IsNullOrEmpty(txtNamaBarang.Text) && !string.IsNullOrEmpty(txtStok.Text) &&
                    !string.IsNullOrEmpty(txtHarga.Text))
                {
                    DialogResult result = MessageBox.Show("Apakah yakin untuk delete data?", "Confirmation", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        sql = "delete from barang where id = " + id;
                        command = new SqlCommand(sql, connection);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Data barang berhasil terdelete");
                            clear();
                            showData();
                        }
                        catch (Exception x)
                        {
                            MessageBox.Show("Error at:" + x);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Semua kolom tidak boleh kosong!");
                }
            }
            else
            {
                MessageBox.Show("Pilih data terlebih dahulu!");
            }
        }

        public void searchData()
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                try
                {
                    string sql = "select * from barang where nama like '%' + @search + '%'";

                    command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@search", txtSearch.Text);
                    adapter = new SqlDataAdapter(command);
                    tabel = new DataTable();
                    adapter.Fill(tabel);

                    dataGridView1.DataSource = tabel;
                    dataGridView1.Columns[0].HeaderText = "ID";
                    dataGridView1.Columns[1].HeaderText = "Nama Barang";
                    dataGridView1.Columns[2].HeaderText = "Stok";
                    dataGridView1.Columns[3].HeaderText = "Harga";
                }
                catch (Exception x)
                {
                    MessageBox.Show("Error at:" + x);
                }
            }
            else
            {
                showData();
            }
        }

        private void button_tambah_Click(object sender, EventArgs e)
        {
            insertData();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            updateData();
        }

        private void button_hapus_Click(object sender, EventArgs e)
        {
            deleteData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchData();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            showData();
        }
    }
}
