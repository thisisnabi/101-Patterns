using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Models.Catalog;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Models.Orders;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Models.Users;

var user = new User("pouya", "heydarabadi", 21, 210);
var product = new Product("Clean Code With C#", "Book", 210);
var order = new Order(user, product, 2);
user.SetNext(product);
product.SetNext(order);

Console.ReadLine();