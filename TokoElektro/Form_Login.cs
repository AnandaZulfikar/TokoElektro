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
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            panel2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 20, 20));
            button_login.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button_login.Width, button_login.Height, 20, 20));
            button_cancel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button_cancel.Width, button_cancel.Height, 20, 20));
            textBox_username.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox_username.Width, textBox_username.Height, 20, 20));
            textBox_password.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox_password.Width, textBox_password.Height, 20, 20));

        }
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

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

                        int idLogin = reader.GetInt32(0);

                        reader.Close();

                        string queryKaryawan = $"SELECT id FROM karyawan WHERE id_login = '{idLogin}'";
                        SqlCommand commandKaryawan = new SqlCommand(queryKaryawan, connection);
                        SqlDataReader readerKaryawan = commandKaryawan.ExecuteReader();

                        if (readerKaryawan.Read())
                        {
                            GlobalVar.karyawan_id = readerKaryawan.GetInt32(0);
                        }

                        readerKaryawan.Close();

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
