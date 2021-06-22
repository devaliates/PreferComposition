using Core.Interfaces.Models;

using System;
using System.ComponentModel;

namespace PreferCompositionWPF.Models
{
    public class KullaniciModel : BaseModel, IKullanici
    {
        private IKisi kisi;

        private string kullaniciAdi;

        private string parola;

        public KullaniciModel()
        {
            kisi = new KisiModel();

            BuildNotify();
        }

        public KullaniciModel(IKisi kisi, String kullaniciAdi, String parola)
        {
            this.kisi = kisi;
            KullaniciAdi = kullaniciAdi;
            Parola = parola;

            BuildNotify();
        }

        private void BuildNotify()
        {
            if (this.kisi is INotifyPropertyChanged notify)
                notify.PropertyChanged += (sender, e) => OnPropertyChanged(e.PropertyName);
        }

        public string Ad
        {
            get => kisi.Ad;
            set => kisi.Ad = value;
        }

        public string KullaniciAdi 
        {
            get => kullaniciAdi; 
            set => SetProperty(ref kullaniciAdi, value); 
        }

        public string Parola 
        { 
            get => parola; 
            set => SetProperty(ref parola, value); 
        }

        public string Soyad
        {
            get => kisi.Soyad;
            set => kisi.Soyad = value;
        }
    }
}