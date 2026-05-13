namespace KutuphaneTakipSistemi.Models
{
    public class Kitap
    {
        public int Id { get; set; }
        public string Ad { get; set; } = "";
        public string Yazar { get; set; } = "";

        public override string ToString()
        {
            return Ad;
        }
    }
}
