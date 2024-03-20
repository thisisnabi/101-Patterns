using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Dto;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Entity;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Interface;

namespace Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Infra.PriceRules
{
    public class AmazonRule : IPriceRule
    {
        public int Priority { get; set; } = 1;
        public PriceModel Calculate(Product product, PriceModel price)
        {
            //fetch the price from Amazon and get the lower price
            return new PriceModel
            {
                Source = Source.Amazon,
                Price = 19_000
            };
        }
    }
}
