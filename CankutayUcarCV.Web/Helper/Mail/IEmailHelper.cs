namespace CankutayUcarCV.Web.Helper.Mail
{
    public interface IEmailHelper
    {
        void Send(SmtpSettings smtpSettings);
        void SendContactEmail(SmtpSettings smtpSettings);
    }
}
