namespace TokoElektro
{
    partial class Admin_Barang
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
            this.button_hapus = new System.Windows.Forms.Button();
            this.button_tambah = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "WELCOME ADMIN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(540, 315);
            this.dataGridView1.TabIndex = 8;
            // 
            // button_hapus
            // 
            this.button_hapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_hapus.FlatAppearance.BorderSize = 0;
            this.button_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hapus.Location = new System.Drawing.Point(189, 73);
            this.button_hapus.Name = "button_hapus";
            this.button_hapus.Size = new System.Drawing.Size(75, 23);
            this.button_hapus.TabIndex = 9;
            this.button_hapus.Text = "Hapus";
            this.button_hapus.UseVisualStyleBackColor = false;
            // 
            // button_tambah
            // 
            this.button_tambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_tambah.FlatAppearance.BorderSize = 0;
            this.button_tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tambah.Location = new System.Drawing.Point(27, 73);
            this.button_tambah.Name = "button_tambah";
            this.button_tambah.Size = new System.Drawing.Size(75, 23);
            this.button_tambah.TabIndex = 10;
            this.button_tambah.Text = "Tambah";
            this.button_tambah.UseVisualStyleBackColor = false;
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_update.FlatAppearance.BorderSize = 0;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Location = new System.Drawing.Point(108, 73);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 11;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin_Barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_tambah);
            this.Controls.Add(this.button_hapus);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Admin_Barang";
            this.Size = new System.Drawing.Size(595, 453);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_hapus;
        private System.Windows.Forms.Button button_tambah;
        private System.Windows.Forms.Button button_update;
    }
}
