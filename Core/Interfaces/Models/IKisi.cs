using Core.Interfaces.Properties;

using System;

namespace Core.Interfaces.Models
{
    public interface IKisi : IAd
    {
        public String Soyad { get; set; }
    }
}