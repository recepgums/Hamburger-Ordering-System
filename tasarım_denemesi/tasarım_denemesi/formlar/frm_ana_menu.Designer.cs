namespace tasarım_denemesi
{
    partial class frm_ana_menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ana_menu));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.saat_tarih = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bttn_musteri_giris = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bttn_calısan_giris = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 43);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(642, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // saat_tarih
            // 
            this.saat_tarih.AutoSize = true;
            this.saat_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saat_tarih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.saat_tarih.Location = new System.Drawing.Point(70, 46);
            this.saat_tarih.Name = "saat_tarih";
            this.saat_tarih.Size = new System.Drawing.Size(0, 20);
            this.saat_tarih.TabIndex = 13;
            this.saat_tarih.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // bttn_musteri_giris
            // 
            this.bttn_musteri_giris.ActiveBorderThickness = 1;
            this.bttn_musteri_giris.ActiveCornerRadius = 20;
            this.bttn_musteri_giris.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bttn_musteri_giris.ActiveForecolor = System.Drawing.Color.White;
            this.bttn_musteri_giris.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.bttn_musteri_giris.BackColor = System.Drawing.SystemColors.Control;
            this.bttn_musteri_giris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_musteri_giris.BackgroundImage")));
            this.bttn_musteri_giris.ButtonText = "Müşteri Girişi";
            this.bttn_musteri_giris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttn_musteri_giris.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_musteri_giris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.bttn_musteri_giris.IdleBorderThickness = 1;
            this.bttn_musteri_giris.IdleCornerRadius = 20;
            this.bttn_musteri_giris.IdleFillColor = System.Drawing.Color.White;
            this.bttn_musteri_giris.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.bttn_musteri_giris.IdleLineColor = System.Drawing.Color.Gold;
            this.bttn_musteri_giris.Location = new System.Drawing.Point(281, 218);
            this.bttn_musteri_giris.Margin = new System.Windows.Forms.Padding(5);
            this.bttn_musteri_giris.Name = "bttn_musteri_giris";
            this.bttn_musteri_giris.Size = new System.Drawing.Size(181, 41);
            this.bttn_musteri_giris.TabIndex = 11;
            this.bttn_musteri_giris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bttn_musteri_giris.Click += new System.EventHandler(this.bttn_musteri_giris_Click);
            // 
            // bttn_calısan_giris
            // 
            this.bttn_calısan_giris.ActiveBorderThickness = 1;
            this.bttn_calısan_giris.ActiveCornerRadius = 20;
            this.bttn_calısan_giris.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bttn_calısan_giris.ActiveForecolor = System.Drawing.Color.White;
            this.bttn_calısan_giris.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.bttn_calısan_giris.BackColor = System.Drawing.SystemColors.Control;
            this.bttn_calısan_giris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_calısan_giris.BackgroundImage")));
            this.bttn_calısan_giris.ButtonText = "Çalışan Girişi";
            this.bttn_calısan_giris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttn_calısan_giris.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_calısan_giris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.bttn_calısan_giris.IdleBorderThickness = 1;
            this.bttn_calısan_giris.IdleCornerRadius = 20;
            this.bttn_calısan_giris.IdleFillColor = System.Drawing.Color.White;
            this.bttn_calısan_giris.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.bttn_calısan_giris.IdleLineColor = System.Drawing.Color.Gold;
            this.bttn_calısan_giris.Location = new System.Drawing.Point(281, 124);
            this.bttn_calısan_giris.Margin = new System.Windows.Forms.Padding(5);
            this.bttn_calısan_giris.Name = "bttn_calısan_giris";
            this.bttn_calısan_giris.Size = new System.Drawing.Size(181, 41);
            this.bttn_calısan_giris.TabIndex = 12;
            this.bttn_calısan_giris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bttn_calısan_giris.Click += new System.EventHandler(this.bttn_calısan_giris_Click);
            // 
            // frm_ana_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 362);
            this.Controls.Add(this.bttn_calısan_giris);
            this.Controls.Add(this.bttn_musteri_giris);
            this.Controls.Add(this.saat_tarih);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frm_ana_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ana_menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_ana_menu_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuCustomLabel saat_tarih;
        private Bunifu.Framework.UI.BunifuThinButton2 bttn_calısan_giris;
        private Bunifu.Framework.UI.BunifuThinButton2 bttn_musteri_giris;
    }
}