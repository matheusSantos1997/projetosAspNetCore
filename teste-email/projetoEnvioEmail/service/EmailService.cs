using System;
using MailKit.Net.Smtp;
using MimeKit;
using projetoEnvioEmail.model;

namespace projetoEnvioEmail.service
{
    public class EmailService : IEmailService
    {
        private readonly EmailConfiguration _emailconfig;

        public EmailService(EmailConfiguration emailconfig)
        {
            _emailconfig = emailconfig;
        }

        [System.Obsolete]
        public void SendEmail(Message message)
        {
            var emailMessage = CreateEmailMessage(message);

            Send(emailMessage);
        }

        [System.Obsolete]
        private MimeMessage CreateEmailMessage(Message message)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress(_emailconfig.From));
            emailMessage.To.AddRange(message.To);
            emailMessage.Subject = message.Subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Text) {
                Text = message.Content
            };

            return emailMessage;
        }

        private void Send(MimeMessage emailMessage)
        {
            using (var client = new SmtpClient())
            {
                try 
                {
                    client.Connect(_emailconfig.SmtpServer, _emailconfig.Port, true);
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    client.Authenticate(_emailconfig.UserName, _emailconfig.Password);
                    client.Send(emailMessage);
                }
                catch
                {
                   throw;
                }
                finally
                {
                    client.Disconnect(true);
                    client.Dispose();
                }
            }
        }
    }
}