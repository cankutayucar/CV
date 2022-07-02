using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CankutayUcarCV.DTOs.Abstract;

namespace CankutayUcarCV.DTOs.Concrete.sosyal_medya_iconsDtos
{
    public class sosyal_medya_iconsGuncelleDto : IBaseDto
    {
        public int id { get; set; }
        public string link { get; set; }
        public string icon { get; set; }
        public int Kullanici_id { get; set; }
    }
}
