using Core.Interfaces.Models;

using System.ComponentModel;

namespace PreferCompositionWPF.Models
{
    public class AdminModel : BaseModel, IAdmin
    {
        private IKullanici kullanici;

        public AdminModel()
        {
            kullanici = new KullaniciModel();
            BuildNotify();
        }

        public AdminModel(IKullanici kullanici)
        {
            this.kullanici = kullanici;
            BuildNotify();
        }

        private void BuildNotify()
        {
            if (this.kullanici is INotifyPropertyChanged notify)
                notify.PropertyChanged += (sender, e) => OnPropertyChanged(e.PropertyName);
        }

        public string KullaniciAdi 
        {
            get => kullanici.KullaniciAdi; 
            set => kullanici.KullaniciAdi = value; 
        }

        public string Parola 
        {
            get => kullanici.Parola;
            set => kullanici.Parola = value;
        }

        public string Soyad 
        {
            get => kullanici.Soyad;
            set => kullanici.Soyad = value;
        }

        public string Ad 
        {
            get => kullanici.Ad;
            set => kullanici.Ad = value;
        }
    }
}
