using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Models.Catalog;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Models.Orders;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Models.Users;

namespace Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Contracts;

public abstract class Chain
{
    protected Chain next { get; set; }
    public void SetNext(Chain next)
    {
        this.next = next;
        if (next.GetType() == typeof(Order))
        {
            Order order = (Order)next;
            OrderRule1(order);
        }

    }

    public void OrderRule1(Order order)
    {
        if (order.User.Score>= order.Product.Score)
        {
            Console.WriteLine("Success");
            // Create Record To Db
        }
        else
            throw new Exception("Your Score Not Enough!!");
    }
}
