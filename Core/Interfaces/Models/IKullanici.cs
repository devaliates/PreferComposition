using System;
using System.ComponentModel;

namespace Core.Interfaces.Models
{
    public interface IKullanici : IKisi
    {
        public String KullaniciAdi { get; set; }

        public String Parola { get; set; }
    }
}