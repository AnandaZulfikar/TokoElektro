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
    public partial class Admin_Karyawan : UserControl
    {
        public SqlConnection connection = new SqlConnection(dbconfig.conn);
        public SqlCommand command;
        public SqlCommand command1;
        public SqlDataAdapter adapter;
        public DataTable tabel;
        public SqlDataReader reader;
        public string sql;
        public int id;
        public int id_login;

        public Admin_Karyawan()
        {
            InitializeComponent();
            button_update.Region = System.Drawing.Region.FromHrgn(Rounded.CreateRoundRectRgn(0, 0, button_update.Width, button_update.Height, 20, 20));
            button_simpan.Region = System.Drawing.Region.FromHrgn(Rounded.CreateRoundRectRgn(0, 0, button_simpan.Width, button_simpan.Height, 20, 20));
            button_hapus.Region = System.Drawing.Region.FromHrgn(Rounded.CreateRoundRectRgn(0, 0, button_hapus.Width, button_hapus.Height, 20, 20));

            showData();
            cmbTugas.Text = "Pilih--";
            cmbJK.Text = "Pilih--";
        }

        public void showData()
        {
            try
            {
                connection.Close();
                connection.Open();

                string sql = "select * from karyawan inner join login on karyawan.id_login = login.id";
                command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);
                tabel = new DataTable();
                adapter.Fill(tabel);

                dataGridView1.DataSource = tabel;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Nama";
                dataGridView1.Columns[2].HeaderText = "Tugas";
                dataGridView1.Columns[3].HeaderText = "No. Telp";
                dataGridView1.Columns[4].HeaderText = "JK";
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].HeaderText = "Username";
                dataGridView1.Columns[8].HeaderText = "Password";
                dataGridView1.Columns[9].Visible = false;

                connection.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error at:" + x);
            }
        }

        public void clear()
        {
            txtNama.Text = "";
            cmbTugas.Text = "Pilih--";
            txtNoTelp.Text = "";
            cmbJK.Text = "Pilih--";
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        public void insertData()
        {
            if (!string.IsNullOrEmpty(txtNama.Text) && cmbTugas.Text != "Pilih--" && !string.IsNullOrEmpty(txtNoTelp.Text) &&
                cmbJK.Text != "Pilih--" && !string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                try
                {
                    connection.Close();
                    connection.Open();

                    string sql = "insert into login (username, password, isAdmin) values (@username, @password, @isAdmin)";
                    command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@username", txtUsername.Text);
                    command.Parameters.AddWithValue("@password", txtPassword.Text);
                    command.Parameters.AddWithValue("@isAdmin", 0);
                    command.ExecuteNonQuery();

                    sql = "select id from login where username = '" + txtUsername.Text + "'" +
                        "and password = '" + txtPassword.Text + "'";
                    command = new SqlCommand(sql, connection);
                    reader = command.ExecuteReader();
                    reader.Read();
                    int id_login = reader.GetInt32(0);

                    connection.Close();
                    connection.Open();

                    sql = "insert into karyawan (nama, tugas, notelp, jk, id_login) values" +
                        "(@nama, @tugas, @notelp, @jk, @id_login)";
                    command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@nama", txtNama.Text);
                    command.Parameters.AddWithValue("@tugas", cmbTugas.Text);
                    command.Parameters.AddWithValue("@notelp", txtNoTelp.Text);
                    command.Parameters.AddWithValue("@jk", cmbJK.Text);
                    command.Parameters.AddWithValue("@id_login", id_login);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Data karyawan berhasil ditambahkan!");
                    clear();
                    showData();
                }
                catch (Exception x)
                {
                    MessageBox.Show("Error at:" + x);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Semua kolom tidak boleh kosong");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;

            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            id_login = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value);

            txtNama.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cmbTugas.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtNoTelp.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cmbJK.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtUsername.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtPassword.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        public void updateData()
        {
            if (dataGridView1.CurrentRow.Selected)
            {
                if (!string.IsNullOrEmpty(txtNama.Text) && cmbTugas.Text != "Pilih--" && !string.IsNullOrEmpty(txtNoTelp.Text) &&
                    cmbJK.Text != "Pilih--" && !string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
                {
                    DialogResult result = MessageBox.Show("Apakah anda ingin update data ?", "Confirmation", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            connection.Close();
                            connection.Open();

                            string sql = "update karyawan set nama = @nama, tugas = @tugas, notelp = @notelp, jk = @jk " +
                                "where id = " + id;
                            command = new SqlCommand(sql, connection);
                            command.Parameters.AddWithValue("@nama", txtNama.Text);
                            command.Parameters.AddWithValue("@tugas", cmbTugas.Text);
                            command.Parameters.AddWithValue("@notelp", txtNoTelp.Text);
                            command.Parameters.AddWithValue("@jk", cmbJK.Text);
                            command.ExecuteNonQuery();

                            string sql1 = "update login set username = @username, password = @password where id = " + id_login;
                            command1 = new SqlCommand(sql1, connection);
                            command1.Parameters.AddWithValue("@username", txtUsername.Text);
                            command1.Parameters.AddWithValue("@password", txtPassword.Text);
                            command1.ExecuteNonQuery();
                            MessageBox.Show("Data barang berhasil diupdate!");
                            clear();
                            showData();
                        }
                        catch (Exception x)
                        {
                            MessageBox.Show("Error at: " + x);
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
                MessageBox.Show("Tolong pilih data terlebih dahulu!");
            }
        }

        public void deleteData()
        {
            if (dataGridView1.CurrentRow.Selected)
            {
                if (!string.IsNullOrEmpty(txtNama.Text) && cmbTugas.Text != "Pilih--" && !string.IsNullOrEmpty(txtNoTelp.Text) &&
                    cmbJK.Text != "Pilih--" && !string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
                {
                    DialogResult result = MessageBox.Show("Apakah yakin untuk delete data?", "Confirmation", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            connection.Close();
                            connection.Open();

                            string sql = "delete from karyawan where id = " + id;
                            string sql1 = "delete from login where id = " + id_login;
                            command = new SqlCommand(sql, connection);
                            command1 = new SqlCommand(sql1, connection);
                            command.ExecuteNonQuery();
                            command1.ExecuteNonQuery();
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

        private void button_simpan_Click(object sender, EventArgs e)
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

        
    }
}
