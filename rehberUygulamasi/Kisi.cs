namespace rehberUygulamasi
{
    public class Kisi{
        private string isim;
        private string soyisim;
        private string telNo;
        public Kisi(string isim, string soyisim, string telNo){
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.TelNo = telNo;
        }

       public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string TelNo { get => telNo; set => telNo = value; }
    }
}
