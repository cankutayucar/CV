namespace CankutayUcarCV.Web.Helper.Mail
{
    public class SmtpSettings
    {
        public string Server { get; set; } = "smtp.office365.com";
        public int Port { get; set; } = 587;
        public string GondericiAdi { get; set; } = "kişi";
        public string GondericiEmailAdres { get; set; } = "";
        public string KullaniciAdi { get; set; } = "";
        public string Sifre { get; set; } = "";
    }
}
