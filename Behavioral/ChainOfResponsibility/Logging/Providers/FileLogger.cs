using Microsoft.Extensions.Logging;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.Logging.Abstractions;

namespace Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.Logging.Providers;
class FileLogger : Logger
{
    protected override LogLevel Level => LogLevel.Information;

    protected override void WriteMessage(string message)
    {
        Console.WriteLine($"File Logger: {message}");
    }
}