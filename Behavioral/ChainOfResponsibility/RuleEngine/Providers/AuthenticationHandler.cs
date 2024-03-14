using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Abstraction;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Model;

namespace Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Providers
{
    public class AuthenticationHandler : RequestHandler
    {
        protected override void ProcessRequest(Request request)
        {
            Console.WriteLine("Authentication handler processing request");
            // Perform authentication logic
        }
    }
}
