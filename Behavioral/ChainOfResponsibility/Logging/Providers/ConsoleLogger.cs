using Microsoft.Extensions.Logging;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.Logging.Abstractions;

namespace Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.Logging.Providers;
class ConsoleLogger : Logger
{
    protected override LogLevel Level => LogLevel.Debug;

    protected override void WriteMessage(string message)
    {
        Console.WriteLine($"Console Logger: {message}");
    }
}