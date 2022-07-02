using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CankutayUcarCV.Entities.Abstract;

namespace CankutayUcarCV.Entities.Conncrete
{
    [Dapper.Contrib.Extensions.Table("Sertifikalar")]
    public class Sertifikalar : IBase
    {
        public int id { get; set; }
        public string icerik { get; set; }
    }
}
