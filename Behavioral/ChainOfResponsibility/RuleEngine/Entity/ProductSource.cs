namespace Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Entity
{
    public class ProductSource
    {
        public Source Source { get; set; }

        public Product Product { get; set; }

        public string Url { get; set; }

        public DateTime LastUpdatedOn { get; set; }
    }
}
