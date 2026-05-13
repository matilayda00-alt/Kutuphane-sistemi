using System;
using System.Collections.Generic;

namespace KutuphaneTakipSistemi.Models
{
    public class Uye
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; } = "";
        public string Telefon { get; set; } = "";
        public string Eposta { get; set; } = "";
        public DateTime KayitTarihi { get; set; } = DateTime.Now;
        public List<KitapBilgisi> OduncKitaplar { get; set; } = new List<KitapBilgisi>();
        public List<UyeAktivite> AktiviteGecmisi { get; set; } = new List<UyeAktivite>();

        public override string ToString()
        {
            return AdSoyad;
        }
    }

    public class UyeAktivite
    {
        public string KitapAdi { get; set; } = "";
        public string IslemTipi { get; set; } = "";
        public string Tarih { get; set; } = "";
        public string TeslimTarihi { get; set; } = "";
    }
}
