using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using MimeKit.Text;


namespace Core.Services.Mailing;

public interface IEmailService
{
    void Send(string to, string subject, string html, string from = null);
}


