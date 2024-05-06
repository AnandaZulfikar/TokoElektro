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
    public partial class Form_Login : Form
    {
        public SqlConnection connection = new SqlConnection(dbconfig.conn);
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataTable tabel;
        public SqlDataReader reader;

        public Form_Login()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            connection.Close();
            connection.Open();

            string query = $"SELECT * FROM login WHERE username = '{textBox_username.Text}' " +
                $"AND password = '{textBox_password.Text}'";

            command = new SqlCommand(query, connection);
            adapter = new SqlDataAdapter(command);
            tabel = new DataTable();
            adapter.Fill(tabel);

            if(tabel.Rows.Count > 0)
            {
                foreach(DataRow dr in tabel.Rows)
                {
                    bool isAdmin = Convert.ToBoolean(dr["isAdmin"]);
                    if (isAdmin)
                    {
                        reader = command.ExecuteReader();
                        reader.Read();
                        GlobalVar.username = reader.GetString(1);

                        this.Hide();
                        DashboardAdmin admin_dash = new DashboardAdmin();
                        admin_dash.Show();
                    } 
                    else
                    {
                        reader = command.ExecuteReader();
                        reader.Read();
                        GlobalVar.username = reader.GetString(1);

                        this.Hide();
                        DashboardKaryawan karyawan_dash = new DashboardKaryawan();
                        karyawan_dash.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("invalid login");
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
