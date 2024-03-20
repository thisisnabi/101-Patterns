using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Dto;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Entity;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Interface;

namespace Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Infra.PriceRules
{
    public class TrendyolRule : IPriceRule
    {
        public int Priority { get; set; } = 2;
        public PriceModel Calculate(Product product, PriceModel price)
        {
            //fetch the price from Trendyol and get the lower price
            return new PriceModel
            {
                Source = Source.Trendyol,
                Price = 8_000
            };
        }
    }
}
