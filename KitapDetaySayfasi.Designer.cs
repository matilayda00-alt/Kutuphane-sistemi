namespace KutuphaneTakipSistemi
{
    partial class KitapDetaySayfasi
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.lblYazar = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.txtOzet = new System.Windows.Forms.TextBox();
            this.lblOzetTitle = new System.Windows.Forms.Label();
            this.pnlDurumIndicator = new System.Windows.Forms.Panel();
            this.lblDurumYazi = new System.Windows.Forms.Label();
            this.pnlOduncBilgi = new System.Windows.Forms.Panel();
            this.lblOduncAlan = new System.Windows.Forms.Label();
            this.lblVerilisTarihi = new System.Windows.Forms.Label();
            this.lblTeslimTarihi = new System.Windows.Forms.Label();
            this.btnKitapTeslimAl = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.pnlOduncVerme = new System.Windows.Forms.Panel();
            this.lblOduncAlanBaslik = new System.Windows.Forms.Label();
            this.txtOduncAlanKisi = new System.Windows.Forms.TextBox();
            this.lblTeslimTarihiBaslik = new System.Windows.Forms.Label();
            this.dtpTeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnOduncVer = new System.Windows.Forms.Button();
            this.pnlOduncBilgi.SuspendLayout();
            this.pnlOduncVerme.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblKitapAdi.Location = new System.Drawing.Point(30, 70);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(113, 32);
            this.lblKitapAdi.Text = "Kitap Adı";
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblYazar.ForeColor = System.Drawing.Color.Gray;
            this.lblYazar.Location = new System.Drawing.Point(32, 110);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(48, 21);
            this.lblYazar.Text = "Yazar";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblKategori.ForeColor = System.Drawing.Color.DimGray;
            this.lblKategori.Location = new System.Drawing.Point(32, 140);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(32, 19);
            this.lblKategori.Text = "Tür";
            // 
            // txtOzet
            // 
            this.txtOzet.BackColor = System.Drawing.Color.White;
            this.txtOzet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOzet.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtOzet.Location = new System.Drawing.Point(35, 210);
            this.txtOzet.Multiline = true;
            this.txtOzet.Name = "txtOzet";
            this.txtOzet.ReadOnly = true;
            this.txtOzet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOzet.Size = new System.Drawing.Size(400, 250);
            this.txtOzet.Text = "Kitap özeti buraya gelecek...";
            // 
            // lblOzetTitle
            // 
            this.lblOzetTitle.AutoSize = true;
            this.lblOzetTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblOzetTitle.Location = new System.Drawing.Point(32, 180);
            this.lblOzetTitle.Name = "lblOzetTitle";
            this.lblOzetTitle.Size = new System.Drawing.Size(100, 21);
            this.lblOzetTitle.Text = "Kitap Özeti:";
            // 
            // pnlDurumIndicator
            // 
            this.pnlDurumIndicator.Location = new System.Drawing.Point(470, 70);
            this.pnlDurumIndicator.Name = "pnlDurumIndicator";
            this.pnlDurumIndicator.Size = new System.Drawing.Size(10, 40);
            // 
            // lblDurumYazi
            // 
            this.lblDurumYazi.AutoSize = true;
            this.lblDurumYazi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblDurumYazi.Location = new System.Drawing.Point(490, 80);
            this.lblDurumYazi.Name = "lblDurumYazi";
            this.lblDurumYazi.Size = new System.Drawing.Size(60, 21);
            this.lblDurumYazi.Text = "Mevcut";
            // 
            // pnlOduncBilgi
            // 
            this.pnlOduncBilgi.BackColor = System.Drawing.Color.White;
            this.pnlOduncBilgi.Controls.Add(this.btnKitapTeslimAl);
            this.pnlOduncBilgi.Controls.Add(this.lblTeslimTarihi);
            this.pnlOduncBilgi.Controls.Add(this.lblVerilisTarihi);
            this.pnlOduncBilgi.Controls.Add(this.lblOduncAlan);
            this.pnlOduncBilgi.Location = new System.Drawing.Point(470, 130);
            this.pnlOduncBilgi.Name = "pnlOduncBilgi";
            this.pnlOduncBilgi.Size = new System.Drawing.Size(300, 200);
            // 
            // lblOduncAlan
            // 
            this.lblOduncAlan.AutoSize = true;
            this.lblOduncAlan.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblOduncAlan.Location = new System.Drawing.Point(20, 20);
            this.lblOduncAlan.Name = "lblOduncAlan";
            this.lblOduncAlan.Size = new System.Drawing.Size(91, 20);
            this.lblOduncAlan.Text = "Ödünç Alan:";
            // 
            // lblVerilisTarihi
            // 
            this.lblVerilisTarihi.AutoSize = true;
            this.lblVerilisTarihi.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblVerilisTarihi.Location = new System.Drawing.Point(20, 50);
            this.lblVerilisTarihi.Name = "lblVerilisTarihi";
            this.lblVerilisTarihi.Size = new System.Drawing.Size(93, 20);
            this.lblVerilisTarihi.Text = "Veriliş Tarihi:";
            // 
            // lblTeslimTarihi
            // 
            this.lblTeslimTarihi.AutoSize = true;
            this.lblTeslimTarihi.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblTeslimTarihi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.lblTeslimTarihi.Location = new System.Drawing.Point(20, 80);
            this.lblTeslimTarihi.Name = "lblTeslimTarihi";
            this.lblTeslimTarihi.Size = new System.Drawing.Size(99, 20);
            this.lblTeslimTarihi.Text = "Teslim Tarihi:";
            // 
            // btnKitapTeslimAl
            // 
            this.btnKitapTeslimAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnKitapTeslimAl.FlatAppearance.BorderSize = 0;
            this.btnKitapTeslimAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapTeslimAl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKitapTeslimAl.ForeColor = System.Drawing.Color.White;
            this.btnKitapTeslimAl.Location = new System.Drawing.Point(20, 140);
            this.btnKitapTeslimAl.Name = "btnKitapTeslimAl";
            this.btnKitapTeslimAl.Size = new System.Drawing.Size(260, 40);
            this.btnKitapTeslimAl.Text = "Kitabı Teslim Al";
            this.btnKitapTeslimAl.UseVisualStyleBackColor = false;
            this.btnKitapTeslimAl.Click += new System.EventHandler(this.btnKitapTeslimAl_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGeri.ForeColor = System.Drawing.Color.White;
            this.btnGeri.Location = new System.Drawing.Point(20, 15);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(120, 30);
            this.btnGeri.Text = "← Listeye Dön";
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // pnlOduncVerme
            // 
            this.pnlOduncVerme.BackColor = System.Drawing.Color.White;
            this.pnlOduncVerme.Controls.Add(this.btnOduncVer);
            this.pnlOduncVerme.Controls.Add(this.dtpTeslimTarihi);
            this.pnlOduncVerme.Controls.Add(this.lblTeslimTarihiBaslik);
            this.pnlOduncVerme.Controls.Add(this.txtOduncAlanKisi);
            this.pnlOduncVerme.Controls.Add(this.lblOduncAlanBaslik);
            this.pnlOduncVerme.Location = new System.Drawing.Point(470, 130);
            this.pnlOduncVerme.Name = "pnlOduncVerme";
            this.pnlOduncVerme.Size = new System.Drawing.Size(300, 240);
            // 
            // lblOduncAlanBaslik
            // 
            this.lblOduncAlanBaslik.AutoSize = true;
            this.lblOduncAlanBaslik.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblOduncAlanBaslik.Location = new System.Drawing.Point(20, 20);
            this.lblOduncAlanBaslik.Name = "lblOduncAlanBaslik";
            this.lblOduncAlanBaslik.Size = new System.Drawing.Size(86, 19);
            this.lblOduncAlanBaslik.Text = "Ödünç Alan:";
            // 
            // txtOduncAlanKisi
            // 
            this.txtOduncAlanKisi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtOduncAlanKisi.Location = new System.Drawing.Point(20, 45);
            this.txtOduncAlanKisi.Name = "txtOduncAlanKisi";
            this.txtOduncAlanKisi.Size = new System.Drawing.Size(260, 25);
            // 
            // lblTeslimTarihiBaslik
            // 
            this.lblTeslimTarihiBaslik.AutoSize = true;
            this.lblTeslimTarihiBaslik.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTeslimTarihiBaslik.Location = new System.Drawing.Point(20, 90);
            this.lblTeslimTarihiBaslik.Name = "lblTeslimTarihiBaslik";
            this.lblTeslimTarihiBaslik.Size = new System.Drawing.Size(91, 19);
            this.lblTeslimTarihiBaslik.Text = "Teslim Tarihi:";
            // 
            // dtpTeslimTarihi
            // 
            this.dtpTeslimTarihi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpTeslimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTeslimTarihi.Location = new System.Drawing.Point(20, 115);
            this.dtpTeslimTarihi.Name = "dtpTeslimTarihi";
            this.dtpTeslimTarihi.Size = new System.Drawing.Size(260, 25);
            // 
            // btnOduncVer
            // 
            this.btnOduncVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnOduncVer.FlatAppearance.BorderSize = 0;
            this.btnOduncVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOduncVer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnOduncVer.ForeColor = System.Drawing.Color.White;
            this.btnOduncVer.Location = new System.Drawing.Point(20, 175);
            this.btnOduncVer.Name = "btnOduncVer";
            this.btnOduncVer.Size = new System.Drawing.Size(260, 40);
            this.btnOduncVer.Text = "Ödünç Ver";
            this.btnOduncVer.UseVisualStyleBackColor = false;
            this.btnOduncVer.Click += new System.EventHandler(this.btnOduncVer_Click);
            // 
            // KitapDetaySayfasi
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.pnlOduncVerme);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.pnlOduncBilgi);
            this.Controls.Add(this.lblDurumYazi);
            this.Controls.Add(this.pnlDurumIndicator);
            this.Controls.Add(this.lblOzetTitle);
            this.Controls.Add(this.txtOzet);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblYazar);
            this.Controls.Add(this.lblKitapAdi);
            this.Name = "KitapDetaySayfasi";
            this.Size = new System.Drawing.Size(800, 500);
            this.pnlOduncBilgi.ResumeLayout(false);
            this.pnlOduncBilgi.PerformLayout();
            this.pnlOduncVerme.ResumeLayout(false);
            this.pnlOduncVerme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblKitapAdi;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.TextBox txtOzet;
        private System.Windows.Forms.Label lblOzetTitle;
        private System.Windows.Forms.Panel pnlDurumIndicator;
        private System.Windows.Forms.Label lblDurumYazi;
        private System.Windows.Forms.Panel pnlOduncBilgi;
        private System.Windows.Forms.Label lblOduncAlan;
        private System.Windows.Forms.Label lblVerilisTarihi;
        private System.Windows.Forms.Label lblTeslimTarihi;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnKitapTeslimAl;
        private System.Windows.Forms.Panel pnlOduncVerme;
        private System.Windows.Forms.Label lblOduncAlanBaslik;
        private System.Windows.Forms.TextBox txtOduncAlanKisi;
        private System.Windows.Forms.Label lblTeslimTarihiBaslik;
        private System.Windows.Forms.DateTimePicker dtpTeslimTarihi;
        private System.Windows.Forms.Button btnOduncVer;
    }
}