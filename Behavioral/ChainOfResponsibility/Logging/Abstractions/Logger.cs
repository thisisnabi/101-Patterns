using Microsoft.Extensions.Logging;

namespace Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.Logging.Abstractions;

abstract class Logger
{
    protected Logger? nextLogger;

    public void SetNextLogger(Logger nextLogger)
    {
        this.nextLogger = nextLogger;
    }

    public void LogMessage(LogLevel level, string message)
    {
        if (this.Level <= level)
        {
            WriteMessage(message);
        }
        if (nextLogger != null)
        {
            nextLogger.LogMessage(level, message);
        }
    }

    protected abstract LogLevel Level { get; }

    protected abstract void WriteMessage(string message);
}