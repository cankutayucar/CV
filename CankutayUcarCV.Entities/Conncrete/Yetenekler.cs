using CankutayUcarCV.Entities.Abstract;

namespace CankutayUcarCV.Entities.Conncrete
{
    [Dapper.Contrib.Extensions.Table("Yetenekler")]
    public class Yetenekler : IBase
    {
        public int id { get; set; }
        public string icerik { get; set; }
    }
}
