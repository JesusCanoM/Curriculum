using Portafolio.Models;
using SendGrid;
using SendGrid.Helpers.Mail;


namespace Portafolio.Services
{
    public interface IMailService
    {
        Task Send(ContactViewModel contact);
    }

    public class SendGridMailService : IMailService
    {
        private readonly IConfiguration configuration;

        public SendGridMailService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task Send(ContactViewModel contact)
        {
            var apiKey = configuration.GetValue<string>("SENDGRID_API_KEY");
            var email = configuration.GetValue<string>("SENDGRID_FROM");
            var name = configuration.GetValue<string>("SENDGRID_NAME");

            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(email, name);
            var subject = $"This client {contact.Email} wants to message you";
            var to = new EmailAddress(email, name);
            var messagePlainText = contact.Message;
            var htmlContent = $"From: {contact.Name} - Email: {contact.Email} - Message: {contact.Message}";
            var singleEmail = MailHelper.CreateSingleEmail(from, to, subject, messagePlainText, htmlContent);
            var reply = await client.SendEmailAsync(singleEmail);

        }
    }

}