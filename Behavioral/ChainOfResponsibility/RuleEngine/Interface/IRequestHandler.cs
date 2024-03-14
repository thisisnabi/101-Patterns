using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Model;

namespace Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Interface
{
    public interface IRequestHandler
    {
        void SetNextHandler(IRequestHandler handler);
        void HandleRequest(Request request);
    }
}
