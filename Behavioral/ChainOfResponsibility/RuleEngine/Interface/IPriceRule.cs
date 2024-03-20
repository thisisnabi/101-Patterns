using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Dto;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Entity;

namespace Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Interface
{
    public interface IPriceRule
    {
        public int Priority { get; set; }

        PriceModel Calculate(Product product,PriceModel price);
    }
}
