using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Abstraction;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Model;

namespace Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Providers
{
    public class AuthorizationHandler : RequestHandler
    {
        protected override void ProcessRequest(Request request)
        {
            Console.WriteLine("Authorization handler processing request");
            // Perform authorization logic
        }

    }
}
