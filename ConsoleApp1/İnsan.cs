using System;

namespace ConsoleApp1
{
    public interface IInsan
    {
        int Vefat();
        string Adı { get; set; }
        string SoyAdı { get; set; }
        string AnneAdı { get; set; }
        string BabaAdı { get; set; }
    }

    public interface IKadın
    {
        string KocaAdı { get; set; }
        Kadın KızDogur(string kızİsmi);
        Erkek ErkekDogur(string erkekİsmi);
        IInsan Dogur(IInsan insan);
    }
    public abstract class Insan : IInsan
    {
        public Insan(string anne, string baba)
        {
            AnneAdı = anne;
            BabaAdı = baba;
            DogumTarihi = DateTime.Now;
        }
        public Insan(string anne, string baba, string adı)
        {
            Adı = adı;
            AnneAdı = anne;
            BabaAdı = baba;
            DogumTarihi = DateTime.Now;
        }
        public string Cinsiyet { get; set; }
        public string Adı { get;  set; }
        public string SoyAdı { get; set; }
        public string AnneAdı { get;  set; }
        public string BabaAdı { get;  set; }
        protected DateTime DogumTarihi { get; private set; }

        public int Vefat()
        {
            return DateTime.Now.Year - DogumTarihi.Year;
        }
    }


    public class Kadın : Insan, IKadın
    {
        public Kadın(string anne, string baba) : base(anne, baba) { Cinsiyet = "Kadın"; }
        public Kadın(string anne, string baba, string adı) : base(anne, baba,adı) { Cinsiyet = "Kadın"; }

        public string KocaAdı { get; set ; }

        public IInsan Dogur(IInsan insan)
        {
            insan.AnneAdı = this.Adı;
            insan.BabaAdı = this.KocaAdı;
            return insan;
        }

        public Erkek ErkekDogur(string erkekİsmi)
        {
           return new Erkek(this.Adı, this.KocaAdı, erkekİsmi);
        }

        public Kadın KızDogur(string kızİsmi)
        {
          return  new Kadın(this.Adı, this.KocaAdı, kızİsmi);
        }
    }

    public class Erkek : Insan
    {
        public Erkek(string anne, string baba) : base(anne, baba) { Cinsiyet = "Erkek"; }
        public Erkek(string anne, string baba, string adı) : base(anne, baba,adı) { Cinsiyet = "Erkek"; }
    }

}
