using Core.Interfaces.Models;

using Newtonsoft.Json;

using PreferCompositionWPF.Models;

using System.ComponentModel;

namespace PreferCompositionWPF.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private IAdmin admin;
        private IKullanici kullanici;
        private IKisi kisi;

        public MainViewModel()
        {
            //Kisi = new KisiModel("Boş ad", "boş soyad");

            //Kullanici = new KullaniciModel(Kisi, "boş kullanıcı adı", "boş parola");

            Kullanici = new KullaniciModel();

            Kullanici.Ad = "Ad";
            Kullanici.KullaniciAdi = "Kullanıcı Adı";
            Kullanici.Parola = "Parola";
            Kullanici.Soyad = "Soyad";

            Admin = new AdminModel(Kullanici);

            var jsonAdmin = JsonConvert.SerializeObject(Admin);

            Admin = JsonConvert.DeserializeObject<AdminModel>(jsonAdmin);


            //Admin = new AdminModel(
            //    new KullaniciModel(
            //            new KisiModel()
            //            {
            //                Ad = "Ali",
            //                Soyad = "Soyad",
            //            }, "boş kullanıcı adı", "boş parola"));
        }


        public IAdmin Admin { get => admin; set => SetProperty(ref admin, value); }
        public IKullanici Kullanici { get => kullanici; set => SetProperty(ref kullanici, value); }
        public IKisi Kisi { get => kisi; set => SetProperty(ref kisi, value); }
    }
}