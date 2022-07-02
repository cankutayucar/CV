using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CankutayUcarCV.DTOs.Abstract;

namespace CankutayUcarCV.DTOs.Concrete.KullaniciDtos
{
    public class KullaniciSifreDto : IBaseDto
    {
        public int id { get; set; }
        public string SIFRE { get; set; }
    }
}
