using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Dto;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Entity;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Interface;

namespace Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Infra.PriceRules
{
    public class DecathlonRule : IPriceRule
    {
        public int Priority { get; set; } = 2;
        public PriceModel Calculate(Product product, PriceModel price)
        {
            //fetch the price from Decathlon and get the lower price
            return new PriceModel
            {
                Source = Source.Decathlon,
                Price = 16_000
            };
        }
    }
}
