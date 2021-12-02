using BL.Interfaces;
using DAL.Interfaces;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Util;
using Google.Apis.Util.Store;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.IO;
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

        private string EditedEmailText(string candidateName, string internshipName, string filepath)
        {
            string emailText = new StreamReader(filepath).ReadToEnd();
            emailText = emailText.Replace("[candidateName]", candidateName);
            emailText = emailText.Replace("[internshipName]", internshipName);
            return emailText;
        }

        private async  Task<SaslMechanismOAuth2> GoogleAuthorisation (ClientSecrets clientSecrets)
        {
            const string GMailAccount = "admntest.team5@gmail.com";
            var codeFlow = new GoogleAuthorizationCodeFlow(new GoogleAuthorizationCodeFlow.Initializer
            {
                DataStore = new FileDataStore("CredentialCacheFolder", false),
                Scopes = new[] { "https://mail.google.com/" },
                ClientSecrets = clientSecrets
            });

            var codeReceiver = new LocalServerCodeReceiver();
            var authCode = new AuthorizationCodeInstalledApp(codeFlow, codeReceiver);

            var credential = await authCode.AuthorizeAsync(GMailAccount, CancellationToken.None);

            if (credential.Token.IsExpired(SystemClock.Default))
                await credential.RefreshTokenAsync(CancellationToken.None);

            var oauth2 = new SaslMechanismOAuth2(credential.UserId, credential.Token.AccessToken);
            return  oauth2;
        }

        public async Task SendEmailAsync(int recipientId)
        {
            var message = new MimeMessage();
            var candidate = await _unitOfWork.Candidates.GetByIdAsync(recipientId);
            var internship = await _unitOfWork.Internships.GetByIdAsync((int)candidate.InternshipId);
            string filepath = @"../Shared/EmailTemplates/DefaultEmail.html";
            if (candidate.StatusType.ToString() == "Approved")
            {
                filepath = @"../Shared/EmailTemplates/ApprovedEmail.html";
            }
            else if (candidate.StatusType.ToString() == "Questionable" || candidate.StatusType.ToString() == "Declined")
            {
                filepath = @"../Shared/EmailTemplates/DeclinedEmail.html";
            }
            
            message.From.Add(new MailboxAddress("Exadel Team5 automatic email sender", "admntest.team5@gmail.com"));
            message.To.Add(new MailboxAddress(candidate.FirstName + " " + candidate.LastName, candidate.Email));
            message.Subject = "Automatic Email Sending Function";

            message.Body = new TextPart("html") { Text = EditedEmailText(candidate.FirstName + " " + candidate.LastName, internship.Name, filepath) };

            var clientSecrets = new ClientSecrets
            {
                ClientId = "967351711447-7j0ihuv3398vus5rm178r1qdjc4hc76a.apps.googleusercontent.com",
                ClientSecret = "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"
            };
            var oauth2 =await GoogleAuthorisation(clientSecrets);
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
