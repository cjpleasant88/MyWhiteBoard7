using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SendEmailNotifications
{
    class SendNotices
    {
        static SmtpConfig _smtp;
        static List<EmailAddress> _subscribers;
        //public static DateTime Now { get; }

        static void Configure()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                //.AddUserSecrets<SendNotices>()
                //.AddEnvironmentVariables()
                ;

            IConfigurationRoot configuration = builder.Build();

            var smtp = new SmtpConfig();
            configuration.GetSection("Email").Bind(smtp);

            _smtp = smtp;

            _subscribers = configuration.GetSection("Subscribers").Get<List<EmailAddress>>();
        }

        static MimeMessage BuildMessage()
        {
            var message = new MimeMessage();

            message.From.Add(new MailboxAddress("NoReply", _smtp.smtpUserName));

            message.To.AddRange(_subscribers.Select(to => new MailboxAddress(to.Name, to.Address)));

            message.Subject = "test mail";
            message.Body = new TextPart("plain")
            {
                Text = $"Hello, you are subscribed to Caleb's application. It is {DateTime.Now.ToShortTimeString()}. Pretty cool!"
            };
            return message;
        }

        static void Send()
        {
            Configure();

            try
            {
                using (var client = new SmtpClient())
                {
                    client.Connect(_smtp.SmtpServer, _smtp.SmtpPort, true);
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    client.Authenticate(_smtp.smtpUserName, _smtp.SmtpPassword);
                    client.Send(BuildMessage());
                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Main(string[] args)
        {
            Send();
        }
    }
}
