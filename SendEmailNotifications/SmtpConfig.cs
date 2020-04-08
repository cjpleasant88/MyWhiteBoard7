
namespace SendEmailNotifications
{
    public class SmtpConfig : ISmtpConfig
    {
        public string SmtpServer { get; set; }

        public int SmtpPort { get; set; }

        public string smtpUserName { get; set; }

        public string SmtpPassword { get; set; }
    }
}
