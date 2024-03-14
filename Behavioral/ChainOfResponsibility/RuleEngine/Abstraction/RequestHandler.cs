using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Interface;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Model;

namespace Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Abstraction
{
    public abstract class RequestHandler : IRequestHandler
    {
        private IRequestHandler _nextHandler;

        public void SetNextHandler(IRequestHandler handler)
        {
            _nextHandler = handler;
        }

        public void HandleRequest(Request request)
        {
            ProcessRequest(request);

            if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
        }

        protected abstract void ProcessRequest(Request request);
    }
}
