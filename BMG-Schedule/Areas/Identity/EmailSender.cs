using Microsoft.AspNetCore.Identity.UI.Services;

namespace BMG_Schedule.Areas.Identity
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            //SendGrid NuGet
        }
    }
}
