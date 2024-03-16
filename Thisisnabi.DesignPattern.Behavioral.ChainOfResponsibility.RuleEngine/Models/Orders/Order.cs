using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Models.Catalog;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Models.Common;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Models.Users;

namespace Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Models.Orders;

public sealed class Order:BaseEntity
{
    #region Ctors
    private Order(User user, Product product, int quantity)
    {
        this.User = user;
        this.Product = product;
        this.Quantity = quantity;
    }
    public Order Create(User user, Product product, int quantity)
        => new Order(user, product, quantity);
    #endregion
    #region Properties
    public User User { get; private set; }
    public Product Product { get; private set; }
    public int Quantity { get; private set; }
    #endregion
    #region Methods
    public void SetUser(User user)
        => this.User = user;
    public void SetProduct(Product product)
        => this.Product = product;
    public void SetQuantity(int quantity)
        => this.Quantity = quantity;
    #endregion
}
