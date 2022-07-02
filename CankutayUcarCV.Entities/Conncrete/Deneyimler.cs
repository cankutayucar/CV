using CankutayUcarCV.Entities.Abstract;

namespace CankutayUcarCV.Entities.Conncrete
{
    [Dapper.Contrib.Extensions.Table("Deneyimler")]
    public class Deneyimler : IBase
    {
        public int id { get; set; }
        public string baslik { get; set; }
        public string altBaslik { get; set; }
        public string icerik { get; set; }
        public DateTime baslangic_tarihi { get; set; }
        public DateTime bitis_tarihi { get; set; }
    }
}
