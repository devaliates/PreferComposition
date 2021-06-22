using Core.Interfaces.Models;

namespace PreferCompositionWPF.Models
{
    public class KisiModel : BaseModel, IKisi
    {
        private string ad;

        private string soyad;

        public KisiModel()
        {

        }

        public KisiModel(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
        }

        public string Ad { get => ad; set => SetProperty(ref ad, value); }

        public string Soyad { get => soyad; set => SetProperty(ref soyad, value); }
    }
}