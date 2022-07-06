using System.Net;
using System.Net.Mail;

namespace CankutayUcarCV.Web.Helper.Mail
{
    public class MailHelper : IEmailHelper
    {
        public void Send(SmtpSettings smtpSettings)
        {
            MailMessage mm = new MailMessage()
            {
                From = new MailAddress(smtpSettings.GondericiEmailAdres),
                To = { new MailAddress("giden kişi eposta (kime gönderiliyor)") },
                Subject = "konu",
                IsBodyHtml = true,
                Body = "içerik"
            };
            SmtpClient smtpClient = new SmtpClient
            {
                Host = smtpSettings.Server,
                Port = smtpSettings.Port,
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(smtpSettings.KullaniciAdi, smtpSettings.Sifre),
                DeliveryMethod = SmtpDeliveryMethod.Network
            };
            smtpClient.Send(mm);
        }

        public void SendContactEmail(SmtpSettings smtpSettings)
        {
            MailMessage mm = new MailMessage()
            {
                From = new MailAddress("gonderen kişi eposta (kim gönderiyor)"),
                To = { new MailAddress("giden kişi eposta (kime gönderiliyor)") },
                Subject = "konu",
                IsBodyHtml = true,
                Body = "içerik"
            };
            SmtpClient smtpClient = new SmtpClient
            {
                Host = smtpSettings.Server,
                Port = smtpSettings.Port,
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(smtpSettings.KullaniciAdi, smtpSettings.Sifre),
                DeliveryMethod = SmtpDeliveryMethod.Network
            };
            smtpClient.Send(mm);
        }
    }
}
