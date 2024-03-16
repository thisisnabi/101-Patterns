using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Contracts;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Models.Common;

namespace Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Models.Catalog;

public sealed class Product : Chain
{
    #region Ctors
    public Product(string name, string category, int score = 0)
    {
        this.Name = name;
        this.Category = category;
        this.Score = score;
    }
    public Product CreateProductWithOutScore(string name, string category)
        => new Product(name: name, category: category);
    public Product CreateProduct(string name, string category, int score)
        => new Product(name: name, category: category, score: score);
    #endregion
    #region Properties
    public string Name { get; private set; }
    public string Category { get; private set; }
    public int Score { get; private set; } = 0;
    #endregion
    #region Methods
    public void SetName(string name)
        => this.Name = name;
    public void SetCategory(string category)
        => this.Category = category;
    public void SetScore(int score)
        => this.Score = score;


    #endregion
}
