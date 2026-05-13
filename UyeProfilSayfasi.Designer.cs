namespace KutuphaneTakipSistemi
{
    partial class UyeProfilSayfasi
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
            this.btnGeri = new System.Windows.Forms.Button();
            this.pnlUyeKarti = new System.Windows.Forms.Panel();
            this.lblKayitTarihi = new System.Windows.Forms.Label();
            this.lblEposta = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.btnUyeSil = new System.Windows.Forms.Button();
            this.flpAktivite = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlUyeKarti.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGeri.ForeColor = System.Drawing.Color.White;
            this.btnGeri.Location = new System.Drawing.Point(20, 20);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(120, 30);
            this.btnGeri.Text = "← Listeye Dön";
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // pnlUyeKarti
            // 
            this.pnlUyeKarti.BackColor = System.Drawing.Color.White;
            this.pnlUyeKarti.Controls.Add(this.lblKayitTarihi);
            this.pnlUyeKarti.Controls.Add(this.lblEposta);
            this.pnlUyeKarti.Controls.Add(this.lblTelefon);
            this.pnlUyeKarti.Controls.Add(this.lblAdSoyad);
            this.pnlUyeKarti.Controls.Add(this.btnUyeSil);
            this.pnlUyeKarti.Location = new System.Drawing.Point(20, 70);
            this.pnlUyeKarti.Name = "pnlUyeKarti";
            this.pnlUyeKarti.Size = new System.Drawing.Size(400, 250);
            // 
            // lblKayitTarihi
            // 
            this.lblKayitTarihi.AutoSize = true;
            this.lblKayitTarihi.Location = new System.Drawing.Point(25, 140);
            this.lblKayitTarihi.Name = "lblKayitTarihi";
            this.lblKayitTarihi.Size = new System.Drawing.Size(78, 19);
            this.lblKayitTarihi.Text = "Kayıt Tarihi";
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.Location = new System.Drawing.Point(25, 105);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(55, 19);
            this.lblEposta.Text = "E-posta";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(25, 70);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(52, 19);
            this.lblTelefon.Text = "Telefon";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblAdSoyad.Location = new System.Drawing.Point(20, 20);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(104, 30);
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // btnUyeSil
            // 
            this.btnUyeSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnUyeSil.ForeColor = System.Drawing.Color.White;
            this.btnUyeSil.Location = new System.Drawing.Point(25, 190);
            this.btnUyeSil.Name = "btnUyeSil";
            this.btnUyeSil.Size = new System.Drawing.Size(350, 35);
            this.btnUyeSil.Text = "🗑 Üyeyi Sil";
            this.btnUyeSil.Click += new System.EventHandler(this.btnUyeSil_Click);
            // 
            // flpAktivite
            // 
            this.flpAktivite.Location = new System.Drawing.Point(440, 70);
            this.flpAktivite.Name = "flpAktivite";
            this.flpAktivite.Size = new System.Drawing.Size(440, 500);
            // 
            // UyeProfilSayfasi
            // 
            this.Controls.Add(this.flpAktivite);
            this.Controls.Add(this.pnlUyeKarti);
            this.Controls.Add(this.btnGeri);
            this.Name = "UyeProfilSayfasi";
            this.Size = new System.Drawing.Size(900, 600);
            this.pnlUyeKarti.ResumeLayout(false);
            this.pnlUyeKarti.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Panel pnlUyeKarti;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.Label lblKayitTarihi;
        private System.Windows.Forms.Button btnUyeSil;
        private System.Windows.Forms.FlowLayoutPanel flpAktivite;
    }
}