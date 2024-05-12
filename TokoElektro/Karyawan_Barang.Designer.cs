namespace TokoElektro
{
    partial class Karyawan_Barang
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_update = new System.Windows.Forms.Button();
            this.button_simpan = new System.Windows.Forms.Button();
            this.button_hapus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_namaBarang = new System.Windows.Forms.TextBox();
            this.textBox_hargaBarang = new System.Windows.Forms.TextBox();
            this.label_hargaBarang = new System.Windows.Forms.Label();
            this.textBox_stokBarang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_refresh = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "WELCOME KARYAWAN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(273, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(294, 303);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_update.FlatAppearance.BorderSize = 0;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Location = new System.Drawing.Point(101, 398);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 14;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_simpan
            // 
            this.button_simpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_simpan.FlatAppearance.BorderSize = 0;
            this.button_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_simpan.Location = new System.Drawing.Point(20, 398);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(75, 23);
            this.button_simpan.TabIndex = 13;
            this.button_simpan.Text = "Simpan";
            this.button_simpan.UseVisualStyleBackColor = false;
            this.button_simpan.Click += new System.EventHandler(this.button_simpan_Click);
            // 
            // button_hapus
            // 
            this.button_hapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_hapus.FlatAppearance.BorderSize = 0;
            this.button_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hapus.Location = new System.Drawing.Point(182, 398);
            this.button_hapus.Name = "button_hapus";
            this.button_hapus.Size = new System.Drawing.Size(75, 23);
            this.button_hapus.TabIndex = 12;
            this.button_hapus.Text = "Hapus";
            this.button_hapus.UseVisualStyleBackColor = false;
            this.button_hapus.Click += new System.EventHandler(this.button_hapus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nama barang :";
            // 
            // textBox_namaBarang
            // 
            this.textBox_namaBarang.BackColor = System.Drawing.Color.LightGray;
            this.textBox_namaBarang.Location = new System.Drawing.Point(30, 138);
            this.textBox_namaBarang.Name = "textBox_namaBarang";
            this.textBox_namaBarang.Size = new System.Drawing.Size(212, 20);
            this.textBox_namaBarang.TabIndex = 16;
            // 
            // textBox_hargaBarang
            // 
            this.textBox_hargaBarang.BackColor = System.Drawing.Color.LightGray;
            this.textBox_hargaBarang.Location = new System.Drawing.Point(30, 199);
            this.textBox_hargaBarang.Name = "textBox_hargaBarang";
            this.textBox_hargaBarang.Size = new System.Drawing.Size(212, 20);
            this.textBox_hargaBarang.TabIndex = 18;
            // 
            // label_hargaBarang
            // 
            this.label_hargaBarang.AutoSize = true;
            this.label_hargaBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hargaBarang.Location = new System.Drawing.Point(27, 181);
            this.label_hargaBarang.Name = "label_hargaBarang";
            this.label_hargaBarang.Size = new System.Drawing.Size(47, 15);
            this.label_hargaBarang.TabIndex = 17;
            this.label_hargaBarang.Text = "Harga :";
            // 
            // textBox_stokBarang
            // 
            this.textBox_stokBarang.BackColor = System.Drawing.Color.LightGray;
            this.textBox_stokBarang.Location = new System.Drawing.Point(30, 265);
            this.textBox_stokBarang.Name = "textBox_stokBarang";
            this.textBox_stokBarang.Size = new System.Drawing.Size(212, 20);
            this.textBox_stokBarang.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Stok :";
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_refresh.FlatAppearance.BorderSize = 0;
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Location = new System.Drawing.Point(182, 87);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 23);
            this.button_refresh.TabIndex = 21;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.LightGray;
            this.txtSearch.Location = new System.Drawing.Point(273, 86);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(212, 20);
            this.txtSearch.TabIndex = 23;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(270, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Search :";
            // 
            // Karyawan_Barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.textBox_stokBarang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_hargaBarang);
            this.Controls.Add(this.label_hargaBarang);
            this.Controls.Add(this.textBox_namaBarang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_simpan);
            this.Controls.Add(this.button_hapus);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Karyawan_Barang";
            this.Size = new System.Drawing.Size(595, 453);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_simpan;
        private System.Windows.Forms.Button button_hapus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_namaBarang;
        private System.Windows.Forms.TextBox textBox_hargaBarang;
        private System.Windows.Forms.Label label_hargaBarang;
        private System.Windows.Forms.TextBox textBox_stokBarang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label5;
    }
}
