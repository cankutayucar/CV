using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CankutayUcarCV.DTOs.Abstract;

namespace CankutayUcarCV.DTOs.Concrete.Ilgi_AlanlariDtos
{
    public class Ilgi_AlanlariGuncelleDto : IBaseDto
    {
        public int id { get; set; }
        public string icerik { get; set; }
    }
}
