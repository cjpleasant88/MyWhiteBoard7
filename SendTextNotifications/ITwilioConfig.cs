
namespace SendTextNotifications
{
    public interface ITwilioConfig
    {
        string TwilioKey { get;}

        string MyKey { get;}

        string TwilioPhone { get; }

        string TwilioRecepient { get; }
    }
}
