using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Entity;

namespace Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Dto
{
    public record PriceModel
    {
        public decimal Price { get; set; }

        public Source Source { get; set; }
    }
}
