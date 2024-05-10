namespace TokoElektro
{
    partial class Karyawan_Transaksi_Add
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_tambah = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_test_id_struk = new System.Windows.Forms.Label();
            this.comboBox_barang = new System.Windows.Forms.ComboBox();
            this.table_keranjang = new System.Windows.Forms.DataGridView();
            this.textBox_qty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_subtotal = new System.Windows.Forms.Label();
            this.button_hapus = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button_bayar = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table_keranjang)).BeginInit();
            this.SuspendLayout();
            // 
            // button_tambah
            // 
            this.button_tambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_tambah.FlatAppearance.BorderSize = 0;
            this.button_tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tambah.Location = new System.Drawing.Point(147, 338);
            this.button_tambah.Name = "button_tambah";
            this.button_tambah.Size = new System.Drawing.Size(96, 23);
            this.button_tambah.TabIndex = 17;
            this.button_tambah.Text = "Tambah barang";
            this.button_tambah.UseVisualStyleBackColor = false;
            this.button_tambah.Click += new System.EventHandler(this.button_tambah_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "WELCOME KARYAWAN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Barang :";
            // 
            // label_test_id_struk
            // 
            this.label_test_id_struk.AutoSize = true;
            this.label_test_id_struk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_test_id_struk.Location = new System.Drawing.Point(27, 81);
            this.label_test_id_struk.Name = "label_test_id_struk";
            this.label_test_id_struk.Size = new System.Drawing.Size(342, 18);
            this.label_test_id_struk.TabIndex = 22;
            this.label_test_id_struk.Text = "label ini untuk test id yg dikirimkan dari struk";
            // 
            // comboBox_barang
            // 
            this.comboBox_barang.FormattingEnabled = true;
            this.comboBox_barang.Location = new System.Drawing.Point(105, 133);
            this.comboBox_barang.Name = "comboBox_barang";
            this.comboBox_barang.Size = new System.Drawing.Size(121, 21);
            this.comboBox_barang.TabIndex = 23;
            // 
            // table_keranjang
            // 
            this.table_keranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_keranjang.Location = new System.Drawing.Point(273, 117);
            this.table_keranjang.Name = "table_keranjang";
            this.table_keranjang.Size = new System.Drawing.Size(294, 270);
            this.table_keranjang.TabIndex = 24;
            this.table_keranjang.DataSourceChanged += new System.EventHandler(this.table_keranjang_DataSourceChanged);
            this.table_keranjang.SelectionChanged += new System.EventHandler(this.table_keranjang_SelectionChanged);
            // 
            // textBox_qty
            // 
            this.textBox_qty.BackColor = System.Drawing.Color.LightGray;
            this.textBox_qty.Location = new System.Drawing.Point(105, 176);
            this.textBox_qty.Name = "textBox_qty";
            this.textBox_qty.Size = new System.Drawing.Size(121, 20);
            this.textBox_qty.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "QTY :";
            // 
            // label_subtotal
            // 
            this.label_subtotal.AutoSize = true;
            this.label_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_subtotal.Location = new System.Drawing.Point(270, 400);
            this.label_subtotal.Name = "label_subtotal";
            this.label_subtotal.Size = new System.Drawing.Size(91, 18);
            this.label_subtotal.TabIndex = 27;
            this.label_subtotal.Text = "Subtotal : -";
            // 
            // button_hapus
            // 
            this.button_hapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_hapus.FlatAppearance.BorderSize = 0;
            this.button_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hapus.Location = new System.Drawing.Point(18, 338);
            this.button_hapus.Name = "button_hapus";
            this.button_hapus.Size = new System.Drawing.Size(93, 23);
            this.button_hapus.TabIndex = 28;
            this.button_hapus.Text = "Hapus barang";
            this.button_hapus.UseVisualStyleBackColor = false;
            this.button_hapus.Click += new System.EventHandler(this.button_hapus_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(270, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "Keranjang :";
            // 
            // button_bayar
            // 
            this.button_bayar.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_bayar.FlatAppearance.BorderSize = 0;
            this.button_bayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_bayar.Location = new System.Drawing.Point(471, 410);
            this.button_bayar.Name = "button_bayar";
            this.button_bayar.Size = new System.Drawing.Size(96, 23);
            this.button_bayar.TabIndex = 30;
            this.button_bayar.Text = "Bayar";
            this.button_bayar.UseVisualStyleBackColor = false;
            this.button_bayar.Click += new System.EventHandler(this.button_bayar_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_refresh.FlatAppearance.BorderSize = 0;
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Location = new System.Drawing.Point(189, 104);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(54, 23);
            this.button_refresh.TabIndex = 31;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // Karyawan_Transaksi_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_bayar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_hapus);
            this.Controls.Add(this.label_subtotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_qty);
            this.Controls.Add(this.table_keranjang);
            this.Controls.Add(this.comboBox_barang);
            this.Controls.Add(this.label_test_id_struk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_tambah);
            this.Controls.Add(this.label1);
            this.Name = "Karyawan_Transaksi_Add";
            this.Size = new System.Drawing.Size(594, 452);
            ((System.ComponentModel.ISupportInitialize)(this.table_keranjang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_tambah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_test_id_struk;
        private System.Windows.Forms.ComboBox comboBox_barang;
        private System.Windows.Forms.DataGridView table_keranjang;
        private System.Windows.Forms.TextBox textBox_qty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_subtotal;
        private System.Windows.Forms.Button button_hapus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_bayar;
        private System.Windows.Forms.Button button_refresh;
    }
}
