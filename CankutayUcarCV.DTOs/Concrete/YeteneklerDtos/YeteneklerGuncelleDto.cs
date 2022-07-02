using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CankutayUcarCV.DTOs.Abstract;

namespace CankutayUcarCV.DTOs.Concrete.YeteneklerDtos
{
    public class YeteneklerGuncelleDto : IBaseDto
    {
        public int id { get; set; }
        public string icerik { get; set; }
    }
}
