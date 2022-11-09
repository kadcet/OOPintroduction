namespace OOPIntroduction
{
    /* Object orianted Programing (Nesne Yönelimli Programlama)
     * Temel Prensipler
     * 1. Encapsulation
     * 2. Inheritance (Kapsülleme)
     * 3. Polymorphism (Çok Biçimlilik)
     * 
     * */
    public class Personel
    {
        // Encapsulation
        #region 1 Yol
        //private string tcno;

        //public void SetTCNO(string _tcno)
        //{
        //    if (String.IsNullOrEmpty(_tcno))
        //        throw new ArgumentNullException("TCNO değeri boş olamaz");
        //    if (_tcno.StartsWith("0"))
        //        throw new ArgumentException("TCNO değerinin ilk basamağı 0 olamaz");
        //    if (_tcno.Length != 11)
        //        throw new ArgumentException("TCNO değeri 11 karakter olmak zorunda");

        //    this.tcno = _tcno;
        //}

        //public string GetTCNO()
        //{
        //    if (String.IsNullOrEmpty(tcno))
        //        return "TCNO kayıtlı değil";
        //    return tcno;
        //} 
        #endregion

        // property (özellik)
        //private string tcno;

        //public string TCNO
        //{
        //    get
        //    {
        //        if (String.IsNullOrEmpty(tcno))
        //            return "TCNO Kayıtlı değil";
        //        return tcno;
        //    }
        //    set
        //    {
        //        if (String.IsNullOrEmpty(value))
        //            throw new ArgumentNullException("TCNO değeri boş olamaz");
        //        if (value.StartsWith("0"))
        //            throw new ArgumentException("TCNO değerinin ilk basamağı 0 olamaz");
        //        if (value.Length != 11)
        //            throw new ArgumentException("TCNO değeri 11 karakter olmak zorunda");

        //        tcno = value;
        //    }
        //}


        // 3. Yol
        public string TCNO { get; set; }

        public Personel()
        {

        }
        
        
        // 
        public Personel(string ad, string soyad)
        {
            this.ad = ad;
            this.soyad = soyad;
        }

        private string ad;
        private string soyad;

        public string AdSoyad { get => ad + " " + soyad; }
        //public string AdSoyad
        //{
        //    get
        //    {
        //        return ad + " " + soyad;
        //    }
        //}
    }

    public class PersonelServic
    {
        public void Kaydet()
        {
            Personel p=new Personel();
            //p.SetTCNO("12345678910");
            //var x=p.GetTCNO;

            // 2. Yol
            p.TCNO = "12345678911";
            var x = p.TCNO;
        }
    }
}