// See https://aka.ms/new-console-template for more information

using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Entity;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Infra;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Interface;
using System.Reflection;

var product = new Product
{
    Sources = new List<ProductSource>
    {
        new()
        {
            Source = Source.Torob,
            Url = "https://torob.com/.."
        },
        new ProductSource
        {
            Source = Source.DigiKala,
            Url = "https://digikala.com/.."
        },
        new ProductSource
        {
            Source = Source.Amazon,
            Url = "https://Amazon.com/.."
        }
    }
};
var ruleType = typeof(IPriceRule);

var rules = Assembly.GetExecutingAssembly().GetTypes()
    .Where(p => ruleType.IsAssignableFrom(p) && !p.IsInterface)
    .Select(q => Activator.CreateInstance(q) as IPriceRule)
    .OrderBy(p => p.Priority).ToList();

var engine = new PriceRuleEngine(rules);

var result = engine.CalculatePrice(product);

Console.WriteLine($"The lowest price is :{result.Price} and available on :{result.Source} ");
