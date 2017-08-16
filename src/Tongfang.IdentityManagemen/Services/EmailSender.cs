using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tongfang.WcfClient;
using Tongfang.WcfClient.Simulator;

namespace Tongfang.IdentityManagemen.Services
{
    // This class is used by the application to send email for account confirmation and password reset.
    // For more details see https://go.microsoft.com/fwlink/?LinkID=532713
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            EmailServiceClient client = ClientFactory.CreateEmailServiceClient();
            await client.SendEmailAsync(email, subject, message);
        }
    }
}
