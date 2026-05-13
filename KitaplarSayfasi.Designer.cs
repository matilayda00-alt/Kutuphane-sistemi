namespace KutuphaneTakipSistemi
{
    partial class KitaplarSayfasi
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
            lblTitle = new Label();
            cmbKategori = new ComboBox();
            lblFiltre = new Label();
            txtArama = new TextBox();
            lblArama = new Label();
            flpKitaplar = new FlowLayoutPanel();
            pnlHeader = new Panel();
            pnlSearchContainer = new Panel();
            pnlLeftFilter = new Panel();
            btnFilterGecikmis = new Button();
            btnFilterOdunc = new Button();
            btnFilterMevcut = new Button();
            btnFilterHepsi = new Button();
            lblLeftFilterTitle = new Label();
            pnlHeader.SuspendLayout();
            pnlSearchContainer.SuspendLayout();
            pnlLeftFilter.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(144, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Kitap Listesi";
            // 
            // cmbKategori
            // 
            cmbKategori.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.Font = new Font("Segoe UI", 10F);
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(680, 45);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(200, 25);
            cmbKategori.TabIndex = 2;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // lblFiltre
            // 
            lblFiltre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFiltre.AutoSize = true;
            lblFiltre.Font = new Font("Segoe UI", 9F);
            lblFiltre.ForeColor = Color.Gray;
            lblFiltre.Location = new Point(680, 25);
            lblFiltre.Name = "lblFiltre";
            lblFiltre.Size = new Size(94, 15);
            lblFiltre.TabIndex = 3;
            lblFiltre.Text = "Kategoriye Göre:";
            // 
            // txtArama
            // 
            txtArama.Anchor = AnchorStyles.Top;
            txtArama.Font = new Font("Segoe UI", 12F);
            txtArama.Location = new Point(0, 20);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(400, 29);
            txtArama.TabIndex = 4;
            txtArama.TextAlign = HorizontalAlignment.Center;
            txtArama.TextChanged += txtArama_TextChanged;
            // 
            // lblArama
            // 
            lblArama.Anchor = AnchorStyles.Top;
            lblArama.AutoSize = true;
            lblArama.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblArama.ForeColor = Color.FromArgb(52, 73, 94);
            lblArama.Location = new Point(160, 2);
            lblArama.Name = "lblArama";
            lblArama.Size = new Size(76, 15);
            lblArama.TabIndex = 5;
            lblArama.Text = "Kitap Adı Ara";
            // 
            // flpKitaplar
            // 
            flpKitaplar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpKitaplar.AutoScroll = true;
            flpKitaplar.BackColor = Color.Transparent;
            flpKitaplar.Location = new Point(210, 110);
            flpKitaplar.Name = "flpKitaplar";
            flpKitaplar.Padding = new Padding(10);
            flpKitaplar.Size = new Size(680, 420);
            flpKitaplar.TabIndex = 6;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(pnlSearchContainer);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblFiltre);
            pnlHeader.Controls.Add(cmbKategori);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(900, 100);
            pnlHeader.TabIndex = 7;
            // 
            // pnlSearchContainer
            // 
            pnlSearchContainer.Anchor = AnchorStyles.Top;
            pnlSearchContainer.Controls.Add(txtArama);
            pnlSearchContainer.Controls.Add(lblArama);
            pnlSearchContainer.Location = new Point(250, 20);
            pnlSearchContainer.Name = "pnlSearchContainer";
            pnlSearchContainer.Size = new Size(400, 60);
            pnlSearchContainer.TabIndex = 6;
            // 
            // pnlLeftFilter
            // 
            pnlLeftFilter.BackColor = Color.White;
            pnlLeftFilter.Controls.Add(btnFilterGecikmis);
            pnlLeftFilter.Controls.Add(btnFilterOdunc);
            pnlLeftFilter.Controls.Add(btnFilterMevcut);
            pnlLeftFilter.Controls.Add(btnFilterHepsi);
            pnlLeftFilter.Controls.Add(lblLeftFilterTitle);
            pnlLeftFilter.Dock = DockStyle.Left;
            pnlLeftFilter.Location = new Point(0, 100);
            pnlLeftFilter.Name = "pnlLeftFilter";
            pnlLeftFilter.Size = new Size(200, 440);
            pnlLeftFilter.TabIndex = 8;
            // 
            // btnFilterGecikmis
            // 
            btnFilterGecikmis.BackColor = Color.White;
            btnFilterGecikmis.FlatAppearance.BorderColor = Color.Red;
            btnFilterGecikmis.FlatStyle = FlatStyle.Flat;
            btnFilterGecikmis.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnFilterGecikmis.ForeColor = Color.Red;
            btnFilterGecikmis.Location = new Point(20, 210);
            btnFilterGecikmis.Name = "btnFilterGecikmis";
            btnFilterGecikmis.Size = new Size(160, 40);
            btnFilterGecikmis.TabIndex = 4;
            btnFilterGecikmis.Text = "İade";
            btnFilterGecikmis.UseVisualStyleBackColor = false;
            btnFilterGecikmis.Click += btnFilterGecikmis_Click;
            // 
            // btnFilterOdunc
            // 
            btnFilterOdunc.BackColor = Color.White;
            btnFilterOdunc.FlatAppearance.BorderColor = Color.Orange;
            btnFilterOdunc.FlatStyle = FlatStyle.Flat;
            btnFilterOdunc.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnFilterOdunc.ForeColor = Color.Orange;
            btnFilterOdunc.Location = new Point(20, 160);
            btnFilterOdunc.Name = "btnFilterOdunc";
            btnFilterOdunc.Size = new Size(160, 40);
            btnFilterOdunc.TabIndex = 3;
            btnFilterOdunc.Text = "Ödünç Verilen";
            btnFilterOdunc.UseVisualStyleBackColor = false;
            btnFilterOdunc.Click += btnFilterOdunc_Click;
            // 
            // btnFilterMevcut
            // 
            btnFilterMevcut.BackColor = Color.White;
            btnFilterMevcut.FlatAppearance.BorderColor = Color.FromArgb(46, 204, 113);
            btnFilterMevcut.FlatStyle = FlatStyle.Flat;
            btnFilterMevcut.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnFilterMevcut.ForeColor = Color.FromArgb(46, 204, 113);
            btnFilterMevcut.Location = new Point(20, 110);
            btnFilterMevcut.Name = "btnFilterMevcut";
            btnFilterMevcut.Size = new Size(160, 40);
            btnFilterMevcut.TabIndex = 5;
            btnFilterMevcut.Text = "Kütüphanede";
            btnFilterMevcut.UseVisualStyleBackColor = false;
            btnFilterMevcut.Click += btnFilterMevcut_Click;
            // 
            // btnFilterHepsi
            // 
            btnFilterHepsi.BackColor = Color.White;
            btnFilterHepsi.FlatAppearance.BorderColor = Color.FromArgb(52, 152, 219);
            btnFilterHepsi.FlatStyle = FlatStyle.Flat;
            btnFilterHepsi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnFilterHepsi.ForeColor = Color.FromArgb(52, 152, 219);
            btnFilterHepsi.Location = new Point(20, 60);
            btnFilterHepsi.Name = "btnFilterHepsi";
            btnFilterHepsi.Size = new Size(160, 40);
            btnFilterHepsi.TabIndex = 6;
            btnFilterHepsi.Text = "Tümü";
            btnFilterHepsi.UseVisualStyleBackColor = false;
            btnFilterHepsi.Click += btnFilterHepsi_Click;
            // 
            // lblLeftFilterTitle
            // 
            lblLeftFilterTitle.AutoSize = true;
            lblLeftFilterTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblLeftFilterTitle.Location = new Point(20, 20);
            lblLeftFilterTitle.Name = "lblLeftFilterTitle";
            lblLeftFilterTitle.Size = new Size(123, 21);
            lblLeftFilterTitle.TabIndex = 7;
            lblLeftFilterTitle.Text = "Durum Filtreleri";
            // 
            // KitaplarSayfasi
            // 
            BackColor = Color.FromArgb(245, 246, 250);
            Controls.Add(pnlLeftFilter);
            Controls.Add(flpKitaplar);
            Controls.Add(pnlHeader);
            Name = "KitaplarSayfasi";
            Size = new Size(900, 540);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSearchContainer.ResumeLayout(false);
            pnlSearchContainer.PerformLayout();
            pnlLeftFilter.ResumeLayout(false);
            pnlLeftFilter.PerformLayout();
            ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label lblFiltre;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.FlowLayoutPanel flpKitaplar;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlSearchContainer;
        private System.Windows.Forms.Panel pnlLeftFilter;
        private System.Windows.Forms.Label lblLeftFilterTitle;
        private System.Windows.Forms.Button btnFilterHepsi;
        private System.Windows.Forms.Button btnFilterMevcut;
        private System.Windows.Forms.Button btnFilterOdunc;
        private System.Windows.Forms.Button btnFilterGecikmis;
    }
}