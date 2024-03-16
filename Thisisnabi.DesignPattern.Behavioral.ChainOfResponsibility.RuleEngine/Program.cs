using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Models.Catalog;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Models.Orders;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Models.Users;

// True
var user = new User("pouya", "heydarabadi", 21, 210);
var product = new Product("Clean Code With C#", "Book", 210);
var order = new Order(user, product, 2);
user.SetNext(product);
product.SetNext(order);

// False
var user2 = new User("alireza", "jabari", 21, 200);
var product2 = new Product("Refactoring With C#", "Book", 250);
var order2 = new Order(user2, product2, 5);
user2.SetNext(product2);
product2.SetNext(order2);



Console.ReadLine();