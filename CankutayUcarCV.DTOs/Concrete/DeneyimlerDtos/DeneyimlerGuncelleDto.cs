using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CankutayUcarCV.DTOs.Abstract;

namespace CankutayUcarCV.DTOs.Concrete.DeneyimlerDtos
{
    public class DeneyimlerGuncelleDto : IBaseDto
    {
        public int id { get; set; }
        public string baslik { get; set; }
        public string altBaslik { get; set; }
        public string icerik { get; set; }
        public DateTime baslangic_tarihi { get; set; }
        public DateTime bitis_tarihi { get; set; }
    }
}
