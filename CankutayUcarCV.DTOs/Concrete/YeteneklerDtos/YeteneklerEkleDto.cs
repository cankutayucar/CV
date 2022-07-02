using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CankutayUcarCV.DTOs.Abstract;

namespace CankutayUcarCV.DTOs.Concrete.YeteneklerDtos
{
    public class YeteneklerEkleDto : IBaseDto
    {
        public string icerik { get; set; }
    }
}
