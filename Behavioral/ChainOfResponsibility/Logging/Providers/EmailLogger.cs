using Microsoft.Extensions.Logging;
using System.Net;
using System.Net.Mail;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.Logging.Abstractions;

namespace Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.Logging.Providers;
class EmailLogger : Logger
{
    protected override LogLevel Level => LogLevel.Warning;

    protected override void WriteMessage(string message)
    {
        using MailMessage mailMessage = new("senderEmail", "receiverEmail", "LogInfo", message);
        using SmtpClient client = new("server", 587)
        {
            EnableSsl = true,
            Credentials = new NetworkCredential("username", "password")
        };
        client.Send(mailMessage);
    }
}