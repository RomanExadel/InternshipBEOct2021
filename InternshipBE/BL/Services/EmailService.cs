using AutoMapper;
using BL.DTOs.CandidateDTOs;
using BL.Interfaces;
using DAL.Interfaces;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Util;
using Google.Apis.Util.Store;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BL.Services
{
    public class EmailService : IEmailService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmailService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task SendEmailAsync(int toId, string subject, string text)
        {
            var message = new MimeMessage();
            var candidate = await _unitOfWork.Candidates.GetByIdAsync(toId);
            
            message.From.Add(new MailboxAddress("Exadel Team5 App preview", "dnikityanov@gmail.com"));
            message.To.Add(new MailboxAddress(candidate.FirstName + " " + candidate.LastName, candidate.Email));
            message.Subject = subject;
            message.Body = new TextPart(TextFormat.Plain) {Text = text };

            const string GMailAccount = "dnikityanov@gmail.com";

            var clientSecrets = new ClientSecrets
            {
                ClientId = "121529229249-haikf6uqelmo50uqbqenroogong06j2b.apps.googleusercontent.com",
                ClientSecret = "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"
            };

            var codeFlow = new GoogleAuthorizationCodeFlow(new GoogleAuthorizationCodeFlow.Initializer
            {
                DataStore = new FileDataStore("CredentialCacheFolder", false),
                Scopes = new[] { "https://mail.google.com/" },
                ClientSecrets = clientSecrets
            });

            // Note: For a web app, you'll want to use AuthorizationCodeWebApp instead.
            var codeReceiver = new LocalServerCodeReceiver();
            var authCode = new AuthorizationCodeInstalledApp(codeFlow, codeReceiver);

            var credential = await authCode.AuthorizeAsync(GMailAccount, CancellationToken.None);

            if (credential.Token.IsExpired(SystemClock.Default))
                await credential.RefreshTokenAsync(CancellationToken.None);

            var oauth2 = new SaslMechanismOAuth2(credential.UserId, credential.Token.AccessToken);

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.gmail.com", 465, SecureSocketOptions.SslOnConnect);
                await client.AuthenticateAsync(oauth2);
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }
        }
    }
}
