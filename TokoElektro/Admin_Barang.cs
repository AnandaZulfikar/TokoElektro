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
        public Admin_Barang()
        {
            InitializeComponent();
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
                dataGridView1.Columns[0].HeaderText = "ID";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
