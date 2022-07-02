using CankutayUcarCV.Entities.Abstract;

namespace CankutayUcarCV.Entities.Conncrete
{
    [Dapper.Contrib.Extensions.Table("sosyal_medya_icons")]
    public class sosyal_medya_icons : IBase
    {
        public int id { get; set; }
        public string link { get; set; }
        public string icon { get; set; }
        public int Kullanici_id { get; set; }
    }
}
