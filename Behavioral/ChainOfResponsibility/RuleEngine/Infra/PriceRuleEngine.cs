using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Dto;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Entity;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Interface;

namespace Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Infra
{
    public class PriceRuleEngine
    {
        private readonly IEnumerable<IPriceRule> _rules;

        public PriceRuleEngine(IEnumerable<IPriceRule> rules)
        {
            _rules=rules;
        }

        public PriceModel CalculatePrice(Product product)
        {
            var price=new PriceModel();
            foreach (var rule in _rules)
            {
                price = rule.Calculate(product, price);
            }

            return price;
        }
    }
}
