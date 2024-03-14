using Microsoft.Extensions.Logging;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.Logging.Abstractions;

namespace Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.Logging.Providers;
class EmailLogger : Logger
{
    protected override LogLevel Level => LogLevel.Warning;

    protected override void WriteMessage(string message)
    {
        Console.WriteLine($"Email Logger: {message}");
    }
}