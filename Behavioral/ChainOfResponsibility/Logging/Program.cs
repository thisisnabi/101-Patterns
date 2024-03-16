using Microsoft.Extensions.Logging;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.Logging.Providers;

var consoleLogger = new ConsoleLogger();
var fileLogger = new FileLogger();
var emailLogger = new EmailLogger();

consoleLogger.SetNextLogger(fileLogger);
fileLogger.SetNextLogger(emailLogger);


consoleLogger.LogMessage(LogLevel.Information, "This is an information.");
consoleLogger.LogMessage(LogLevel.Warning, "This is a warning.");
consoleLogger.LogMessage(LogLevel.Error, "This is an error.");