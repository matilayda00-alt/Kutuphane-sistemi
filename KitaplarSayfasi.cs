using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using KutuphaneTakipSistemi.Models;

namespace KutuphaneTakipSistemi
{
    public partial class KitaplarSayfasi : UserControl
    {
        private List<KitapBilgisi> kitaplar = new List<KitapBilgisi>();
        private AnaForm anaForm;

        public KitaplarSayfasi(AnaForm form)
        {
            InitializeComponent();
            this.anaForm = form;
            this.Dock = DockStyle.Fill;
            
            KategorileriDoldur();
            KitaplariYukle();
        }

        private void KategorileriDoldur()
        {
            cmbKategori.Items.Clear();
            cmbKategori.Items.Add("Hepsi");
            cmbKategori.Items.Add("Dünya Klasikleri");
            cmbKategori.Items.Add("Türk Edebiyatı");
            cmbKategori.Items.Add("Bilim Kurgu");
            cmbKategori.Items.Add("Polisiye");
            cmbKategori.Items.Add("Macera");
            cmbKategori.Items.Add("Modern Edebiyat");
            cmbKategori.Items.Add("Tarih");
            cmbKategori.Items.Add("Felsefe");
            cmbKategori.SelectedIndex = 0;
        }

        public List<KitapBilgisi> GetKitaplar()
        {
            return kitaplar;
        }

        private void KitaplariYukle()
        {
            try
            {
                kitaplar.Clear();
                string query = "SELECT * FROM Kitaplar";
                var dt = DatabaseHelper.ExecuteQuery(query);

                foreach (System.Data.DataRow row in dt.Rows)
                {
                    kitaplar.Add(new KitapBilgisi { 
                        Id = Convert.ToInt32(row["Id"]), 
                        Ad = row["Ad"]?.ToString() ?? "", 
                        Yazar = row["Yazar"]?.ToString() ?? "", 
                        Kategori = row["Kategori"]?.ToString() ?? "", 
                        Durum = row["Durum"]?.ToString() ?? "",
                        Ozet = row["Ozet"]?.ToString() ?? "",
                        AlanKisi = row["AlanUye"]?.ToString() ?? "",
                        VermisTarih = row["VerilisTarihi"]?.ToString() ?? "",
                        AlinacakTarih = row["TeslimTarihi"]?.ToString() ?? ""
                    });
                }

                KartlariGoster(kitaplar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitaplar yüklenirken hata: " + ex.Message);
            }
        }

        private bool IsKitapGecikmis(KitapBilgisi k)
        {
            if (k.Durum != "Mevcut" && DateTime.TryParse(k.AlinacakTarih, out DateTime tarih))
            {
                return tarih.Date < DateTime.Now.Date;
            }
            return false;
        }

        private void KartlariGoster(List<KitapBilgisi> liste)
        {
            flpKitaplar.Controls.Clear();

            int gecikmisToplam = 0;
            if (kitaplar != null)
            {
                foreach (var k in kitaplar)
                {
                    if (IsKitapGecikmis(k)) gecikmisToplam++;
                }
            }
            btnFilterGecikmis.Text = "İade (" + gecikmisToplam + ")";

            foreach (var k in liste)
            {
                bool gecikmis = IsKitapGecikmis(k);

                Panel pnlKart = new Panel();
                pnlKart.Size = new Size(260, 120);
                pnlKart.BackColor = Color.White;
                pnlKart.Margin = new Padding(10);
                pnlKart.Cursor = Cursors.Hand;
                pnlKart.Click += (s, e) => anaForm.SayfaDegistir(new KitapDetaySayfasi(anaForm, k));

                if (gecikmis)
                {
                    Label lblUnlem = new Label();
                    lblUnlem.Text = "!";
                    lblUnlem.Font = new Font("Segoe UI Black", 14, FontStyle.Bold);
                    lblUnlem.ForeColor = Color.Red;
                    lblUnlem.AutoSize = true;
                    lblUnlem.Location = new Point(235, 5);
                    pnlKart.Controls.Add(lblUnlem);
                }

                Label lblAd = new Label();
                lblAd.Text = k.Ad;
                lblAd.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);
                lblAd.Location = new Point(10, 10);
                lblAd.Size = new Size(220, 25);
                lblAd.Click += (s, e) => anaForm.SayfaDegistir(new KitapDetaySayfasi(anaForm, k));

                Label lblYazar = new Label();
                lblYazar.Text = k.Yazar;
                lblYazar.Font = new Font("Segoe UI", 9);
                lblYazar.ForeColor = Color.Gray;
                lblYazar.Location = new Point(10, 35);
                lblYazar.Size = new Size(240, 20);
                lblYazar.Click += (s, e) => anaForm.SayfaDegistir(new KitapDetaySayfasi(anaForm, k));

                Panel pnlDurum = new Panel();
                pnlDurum.Dock = DockStyle.Bottom;
                pnlDurum.Height = 30;
                
                string durumMetni = k.Durum;

                if (k.Durum == "Mevcut")
                {
                    pnlDurum.BackColor = Color.FromArgb(46, 204, 113);
                }
                else if (gecikmis)
                {
                    pnlDurum.BackColor = Color.Red;
                    durumMetni = "İade Gerekli!";
                }
                else
                {
                    pnlDurum.BackColor = Color.Orange;
                }

                Label lblDurum = new Label();
                lblDurum.Text = durumMetni;
                lblDurum.ForeColor = Color.White;
                lblDurum.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                lblDurum.TextAlign = ContentAlignment.MiddleCenter;
                lblDurum.Dock = DockStyle.Fill;
                lblDurum.Click += (s, e) => anaForm.SayfaDegistir(new KitapDetaySayfasi(anaForm, k));

                pnlDurum.Controls.Add(lblDurum);
                pnlKart.Controls.Add(lblAd);
                pnlKart.Controls.Add(lblYazar);
                pnlKart.Controls.Add(pnlDurum);

                flpKitaplar.Controls.Add(pnlKart);
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            string arama = txtArama.Text.ToLower();
            string kategori = cmbKategori.SelectedItem?.ToString() ?? "Hepsi";

            var filtrelenmis = kitaplar.FindAll(k => 
                (k.Ad.ToLower().Contains(arama) || k.Yazar.ToLower().Contains(arama)) &&
                (kategori == "Hepsi" || k.Kategori == kategori)
            );

            KartlariGoster(filtrelenmis);
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtArama_TextChanged(this, EventArgs.Empty);
        }

        private void btnFilterHepsi_Click(object sender, EventArgs e)
        {
            KartlariGoster(kitaplar);
            ButonRenkleriniGuncelle(btnFilterHepsi);
        }

        private void btnFilterMevcut_Click(object sender, EventArgs e)
        {
            var filtrelenmis = kitaplar.FindAll(k => k.Durum == "Mevcut");
            KartlariGoster(filtrelenmis);
            ButonRenkleriniGuncelle(btnFilterMevcut);
        }

        private void btnFilterOdunc_Click(object sender, EventArgs e)
        {
            var filtrelenmis = kitaplar.FindAll(k => k.Durum == "Ödünçte" || k.Durum == "Ödünç Verildi");
            KartlariGoster(filtrelenmis);
            ButonRenkleriniGuncelle(btnFilterOdunc);
        }

        private void btnFilterGecikmis_Click(object sender, EventArgs e)
        {
            var filtrelenmis = kitaplar.FindAll(k => IsKitapGecikmis(k));
            KartlariGoster(filtrelenmis);
            ButonRenkleriniGuncelle(btnFilterGecikmis);
        }

        private void ButonRenkleriniGuncelle(Button secilenButon)
        {
            btnFilterHepsi.BackColor = Color.White;
            btnFilterHepsi.ForeColor = Color.FromArgb(52, 152, 219);
            
            btnFilterMevcut.BackColor = Color.White;
            btnFilterMevcut.ForeColor = Color.FromArgb(46, 204, 113);

            btnFilterOdunc.BackColor = Color.White;
            btnFilterOdunc.ForeColor = Color.Orange;

            btnFilterGecikmis.BackColor = Color.White;
            btnFilterGecikmis.ForeColor = Color.Red;

            secilenButon.BackColor = secilenButon.ForeColor;
            secilenButon.ForeColor = Color.White;
        }
    }

    public class KitapBilgisi
    {
        public int Id { get; set; }
        public string Ad { get; set; } = "";
        public string Yazar { get; set; } = "";
        public string Kategori { get; set; } = "";
        public string Durum { get; set; } = "";
        public string Ozet { get; set; } = "";
        public string AlanKisi { get; set; } = "";
        public string VermisTarih { get; set; } = "";
        public string AlinacakTarih { get; set; } = "";
    }
}
