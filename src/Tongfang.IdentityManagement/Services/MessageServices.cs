using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using Tongfang.WcfClient.Simulator;

namespace Tongfang.IdentityManagement.Services
{
    // This class is used by the application to send Email and SMS
    // when you turn on two-factor authentication in ASP.NET Identity.
    // For more details see this link https://go.microsoft.com/fwlink/?LinkID=532713
    public class AuthMessageSender : IEmailSender, ISmsSender
    {
        protected SmsServiceClient CreateSmsClient()
        {
            string url = "net.msmq://localhost/private/HYMIS_SMS_MSMQ";
            EndpointAddress endpointAddress = new EndpointAddress(url);
            Binding binding = new NetMsmqBinding(NetMsmqSecurityMode.None);
            ChannelFactory<ISmsService> channelFactory = new ChannelFactory<ISmsService>(binding, endpointAddress);
            return new SmsServiceClient(binding, endpointAddress);
        }

        public Task SendEmailAsync(string email, string subject, string message)
        {
            // Plug in your email service here to send an email.
            return Task.FromResult(0);
        }

        public Task SendSmsAsync(string number, string message)
        {
            // Plug in your SMS service here to send a text message.
            return Task.FromResult(0);
        }
    }
}
