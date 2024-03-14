using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Abstraction;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Model;

namespace Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Providers
{
    public class ValidationHandler : RequestHandler
    {
        protected override void ProcessRequest(Request request)
        {
            Console.WriteLine("Validation handler processing request");
            // Perform validation logic
        }
    }
}
