namespace KutuphaneTakipSistemi
{
    partial class MenuSayfasi
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
            this.btnKitaplar = new System.Windows.Forms.Button();
            this.btnUyeler = new System.Windows.Forms.Button();
            this.btnUyeKayit = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlMenuContainer = new System.Windows.Forms.Panel();
            this.pnlMenuContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKitaplar
            // 
            this.btnKitaplar.BackColor = System.Drawing.Color.White;
            this.btnKitaplar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKitaplar.FlatAppearance.BorderSize = 0;
            this.btnKitaplar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitaplar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnKitaplar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnKitaplar.Location = new System.Drawing.Point(0, 50);
            this.btnKitaplar.Name = "btnKitaplar";
            this.btnKitaplar.Size = new System.Drawing.Size(220, 150);
            this.btnKitaplar.TabIndex = 0;
            this.btnKitaplar.Text = "\n\n📚\n\nKitaplar Listesi";
            this.btnKitaplar.UseVisualStyleBackColor = false;
            this.btnKitaplar.Click += new System.EventHandler(this.btnKitaplar_Click);
            // 
            // btnUyeler
            // 
            this.btnUyeler.BackColor = System.Drawing.Color.White;
            this.btnUyeler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUyeler.FlatAppearance.BorderSize = 0;
            this.btnUyeler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUyeler.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnUyeler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnUyeler.Location = new System.Drawing.Point(260, 50);
            this.btnUyeler.Name = "btnUyeler";
            this.btnUyeler.Size = new System.Drawing.Size(220, 150);
            this.btnUyeler.TabIndex = 1;
            this.btnUyeler.Text = "\n\n👥\n\nÜyeler";
            this.btnUyeler.UseVisualStyleBackColor = false;
            this.btnUyeler.Click += new System.EventHandler(this.btnUyeler_Click);
            // 
            // btnUyeKayit
            // 
            this.btnUyeKayit.BackColor = System.Drawing.Color.White;
            this.btnUyeKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUyeKayit.FlatAppearance.BorderSize = 0;
            this.btnUyeKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUyeKayit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnUyeKayit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnUyeKayit.Location = new System.Drawing.Point(520, 50);
            this.btnUyeKayit.Name = "btnUyeKayit";
            this.btnUyeKayit.Size = new System.Drawing.Size(220, 150);
            this.btnUyeKayit.TabIndex = 2;
            this.btnUyeKayit.Text = "\n\n➕\n\nÜye Kayıt";
            this.btnUyeKayit.UseVisualStyleBackColor = false;
            this.btnUyeKayit.Click += new System.EventHandler(this.btnUyeKayit_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblWelcome.Location = new System.Drawing.Point(0, 80);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(900, 60);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Kütüphane Yönetim Paneli";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMenuContainer
            // 
            this.pnlMenuContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMenuContainer.Controls.Add(this.btnKitaplar);
            this.pnlMenuContainer.Controls.Add(this.btnUyeler);
            this.pnlMenuContainer.Controls.Add(this.btnUyeKayit);
            this.pnlMenuContainer.Location = new System.Drawing.Point(80, 175);
            this.pnlMenuContainer.Name = "pnlMenuContainer";
            this.pnlMenuContainer.Size = new System.Drawing.Size(740, 250);
            this.pnlMenuContainer.TabIndex = 4;
            // 
            // MenuSayfasi
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.pnlMenuContainer);
            this.Controls.Add(this.lblWelcome);
            this.Name = "MenuSayfasi";
            this.Size = new System.Drawing.Size(900, 600);
            this.pnlMenuContainer.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnKitaplar;
        private System.Windows.Forms.Button btnUyeler;
        private System.Windows.Forms.Button btnUyeKayit;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlMenuContainer;
    }
}