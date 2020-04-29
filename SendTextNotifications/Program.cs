using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using System.Threading;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SendTextNotifications
{
    class Program
    {
        static void Main()
        {
            Send();
        }

        static void Send()
        {
            Configure();
            //TwilioClient.Init(
            //    Environment.GetEnvironmentVariable(""),
            //    Environment.GetEnvironmentVariable(""));
            try
            {

                TwilioClient.Init(_twilioAccount.TwilioKey, _twilioAccount.MyKey);
                bool sent = false;
                while (true)
                {

                    if (DateTime.Now.Minute % 5 == 0 && sent == false)
                    {

                        MessageResource.Create(
                             to: new PhoneNumber(_twilioAccount.TwilioRecepient),
                             from: new PhoneNumber(_twilioAccount.TwilioPhone),
                                body: $"{DateTime.Now.Minute} {DateTime.Now.Second} Did you get this!? -Caleb");
                        sent = true;
                        Thread.Sleep(60000 * 4);
                    }
                    if (sent == true && DateTime.Now.Minute % 5 != 0)
                    {
                        sent = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static TwilioConfig _twilioAccount;

        static void Configure()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                //.AddUserSecrets<SendNotices>()
                //.AddEnvironmentVariables()
                ;

            IConfigurationRoot configuration = builder.Build();

            var twilio = new TwilioConfig();

            configuration.GetSection("Twilio").Bind(twilio);

            _twilioAccount = twilio;

            //_subscribers = configuration.GetSection("Subscribers").Get<List<EmailAddress>>();
        }
    }
    //class Program
    //{
    //    static void ReadConfiguration()
    //    {
    //        var appConfig = new ConfigurationBuilder()
    //            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
    //        IConfigurationRoot configuration = appConfig.Build();

    //        string[] items = configuration.GetSection("Pizza:size").Get<List<string>>();
    //        foreach (var s in items) Console.WriteLine(s);

    //    }

    //    static void Main(string[] args)
    //    {
    //        ReadConfiguration();
    //    }
    //}
}
