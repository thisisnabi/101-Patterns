using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Dto;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Entity;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Interface;

namespace Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Infra.PriceRules
{
    public class DigiKalaRule : IPriceRule
    {
        public int Priority { get; set; } = 3;
        public PriceModel Calculate(Product product, PriceModel price)
        {
            //fetch the price from DigiKala and get the lower price
            return new PriceModel
            {
                Source = Source.DigiKala,
                Price = 15_000
            };
        }
    }
}
