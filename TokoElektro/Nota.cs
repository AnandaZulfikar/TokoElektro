using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

/**
 * example usage:
 * Nota.NotaPrinter nota = new Nota.NotaPrinter(idstruk);
 * nota.PrintNota();
 */

namespace TokoElektro
{
    internal class Nota
    {
        public class NotaPrinter
        {
            private PrintDocument printDocument;
            private Font fontTitle;
            private Font fontBody;
            private string content;

            public NotaPrinter(int idStruk)
            {
                printDocument = new PrintDocument();
                printDocument.PrintPage += new PrintPageEventHandler(PrintPage);

                fontTitle = new Font("Arial", 14, FontStyle.Bold);
                fontBody = new Font("Arial", 10);

                GetContentFromDatabase(idStruk);
            }

            private void GetContentFromDatabase(int idStruk)
            {
                string query = $"SELECT struk.id AS id_struk, struk.tanggal, struk.total, struk.bayar, struk.kembali, " +
                               $"karyawan.nama AS nama_karyawan, " +
                               $"barang.nama AS nama_barang, barang.harga AS harga_barang, " +
                               $"transaksi.quantity, transaksi.sub_total " +
                               $"FROM struk " +
                               $"JOIN karyawan ON struk.id_karyawan = karyawan.id " +
                               $"JOIN transaksi ON struk.id = transaksi.id_struk " +
                               $"JOIN barang ON transaksi.id_barang = barang.id " +
                               $"WHERE struk.id = {idStruk}";

                using (SqlConnection connection = new SqlConnection(dbconfig.conn))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            string idTransaksi = reader["id_struk"].ToString();
                            string tanggal = reader["tanggal"].ToString();
                            int total = Convert.ToInt32(reader["total"]);
                            int bayar = Convert.ToInt32(reader["bayar"]);
                            int kembali = Convert.ToInt32(reader["kembali"]);
                            string namaKaryawan = reader["nama_karyawan"].ToString();

                            // Konten nota
                            var table = new Table("No", "Nama Barang", "Harga", "QTY", "Subtotal");
                            int counter = 1;

                            // Detail barang
                            do
                            {
                                string namaBarang = reader["nama_barang"].ToString();
                                string hargaBarang = Convert.ToInt32(reader["harga_barang"]).ToString("C", new CultureInfo("id-ID"));
                                string qty = reader["quantity"].ToString();
                                string subtotal = Convert.ToInt32(reader["sub_total"]).ToString("C", new CultureInfo("id-ID"));

                                // Baris ke tabel
                                table.AddRow(counter++, namaBarang, hargaBarang, qty, subtotal);
                            } while (reader.Read());

                            // Tabel transaksi
                            content = $"========= Nota Transaksi =========\n\n" +
                                      $"ID Transaksi: {idTransaksi}\n" +
                                      $"Tanggal: {tanggal}\n" +
                                      $"Karyawan: {namaKaryawan}\n";

                            content += table.ToString();

                            // Footer
                            content += $"\nTotal: Rp. {total.ToString("C", new CultureInfo("id-ID"))}\n";
                            content += $"Bayar: Rp. {bayar.ToString("C", new CultureInfo("id-ID"))}\n";
                            content += $"Kembali: Rp. {kembali.ToString("C", new CultureInfo("id-ID"))}\n";
                            content += "=================================";
                        }

                        connection.Close();
                    }
                }
            }



            public void PrintNota()
            {
                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                printPreviewDialog.Document = printDocument;
                printPreviewDialog.ShowDialog();
            }

            private void PrintPage(object sender, PrintPageEventArgs e)
            {
                float startX = 10;
                float startY = 10;
                float offset = 30;
                float lineHeight = fontBody.GetHeight();

                using (Graphics g = e.Graphics)
                {
                    g.DrawString(content, fontBody, Brushes.Black, startX, startY);

                    float totalHeight = fontBody.GetHeight() * content.Split('\n').Length;

                    if (totalHeight > e.MarginBounds.Height)
                    {
                        e.HasMorePages = true;
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }
                }
            }
        }


    }
}
