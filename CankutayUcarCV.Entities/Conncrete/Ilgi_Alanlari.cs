using CankutayUcarCV.Entities.Abstract;

namespace CankutayUcarCV.Entities.Conncrete
{
    [Dapper.Contrib.Extensions.Table("Ilgi_Alanlari")]
    public class Ilgi_Alanlari : IBase
    {
        public int id { get; set; }
        public string icerik { get; set; }
    }
}
