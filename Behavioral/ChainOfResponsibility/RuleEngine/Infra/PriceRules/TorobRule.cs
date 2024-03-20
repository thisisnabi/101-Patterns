using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Dto;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Entity;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Interface;

namespace Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Infra.PriceRules
{
    public class TorobRule : IPriceRule
    {
        public int Priority { get; set; } = 4;
        public PriceModel Calculate(Product product, PriceModel price)
        {
            //fetch the price from Torob and get the lower price
            return new PriceModel
            {
                Source = Source.Torob,
                Price = 10_000
            };
        }
    }
}
