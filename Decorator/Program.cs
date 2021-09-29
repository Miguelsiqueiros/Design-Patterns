using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var notifier = new Notifier();
            var notifierWithSMS = new SMSDecorator(notifier);
            var notfierWithSMSAndSlack = new SlackDecorator(notifierWithSMS);
            var notifierWithSMSAndSlackAndFacebook = new FacebookDecorator(notfierWithSMSAndSlack);

            notifierWithSMSAndSlackAndFacebook.send("Hello");
        }
    }
}
