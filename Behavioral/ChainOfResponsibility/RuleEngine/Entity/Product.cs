namespace Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Entity
{
    public class Product
    {
        public Product()
        {
            Sources=new List<ProductSource>();
        }
        public int Id { get; set; }

        public decimal Price { get; set; }
        public decimal SalePrice { get; set; }

        public ICollection<ProductSource> Sources { get; set; }
    }
}
