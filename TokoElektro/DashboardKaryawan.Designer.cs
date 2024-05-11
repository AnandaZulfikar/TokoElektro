namespace TokoElektro
{
    partial class DashboardKaryawan
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Logout = new System.Windows.Forms.Button();
            this.button_struk = new System.Windows.Forms.Button();
            this.button_barang = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_Logout);
            this.panel1.Controls.Add(this.button_struk);
            this.panel1.Controls.Add(this.button_barang);
            this.panel1.Controls.Add(this.button_home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 450);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "SIM PEMBELIAN";
            // 
            // button_Logout
            // 
            this.button_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Logout.FlatAppearance.BorderSize = 0;
            this.button_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Logout.Location = new System.Drawing.Point(31, 408);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(117, 30);
            this.button_Logout.TabIndex = 5;
            this.button_Logout.Text = "Logout";
            this.button_Logout.UseVisualStyleBackColor = false;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // button_struk
            // 
            this.button_struk.BackColor = System.Drawing.Color.AliceBlue;
            this.button_struk.FlatAppearance.BorderSize = 0;
            this.button_struk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_struk.Location = new System.Drawing.Point(3, 176);
            this.button_struk.Name = "button_struk";
            this.button_struk.Size = new System.Drawing.Size(183, 49);
            this.button_struk.TabIndex = 2;
            this.button_struk.Text = "Struk";
            this.button_struk.UseVisualStyleBackColor = false;
            this.button_struk.Click += new System.EventHandler(this.button_struk_Click);
            // 
            // button_barang
            // 
            this.button_barang.BackColor = System.Drawing.Color.AliceBlue;
            this.button_barang.FlatAppearance.BorderSize = 0;
            this.button_barang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_barang.Location = new System.Drawing.Point(3, 121);
            this.button_barang.Name = "button_barang";
            this.button_barang.Size = new System.Drawing.Size(183, 49);
            this.button_barang.TabIndex = 1;
            this.button_barang.Text = "Barang";
            this.button_barang.UseVisualStyleBackColor = false;
            this.button_barang.Click += new System.EventHandler(this.button_barang_Click);
            // 
            // button_home
            // 
            this.button_home.BackColor = System.Drawing.Color.AliceBlue;
            this.button_home.FlatAppearance.BorderSize = 0;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.Location = new System.Drawing.Point(3, 66);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(183, 49);
            this.button_home.TabIndex = 0;
            this.button_home.Text = "Home";
            this.button_home.UseVisualStyleBackColor = false;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // DashboardKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "DashboardKaryawan";
            this.Text = "DashboardKaryawan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Logout;
        private System.Windows.Forms.Button button_struk;
        private System.Windows.Forms.Button button_barang;
        private System.Windows.Forms.Button button_home;
    }
}