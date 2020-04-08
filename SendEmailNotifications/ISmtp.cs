
namespace SendEmailNotifications
{
    public interface ISmtpConfig
    {
        string SmtpServer { get; }

        int SmtpPort { get; }

        string smtpUserName { get; set; }

        string SmtpPassword { get; set; }
    }
}
