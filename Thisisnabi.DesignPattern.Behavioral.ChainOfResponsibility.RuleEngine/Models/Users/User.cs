using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Models.Common;

namespace Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Models.Users;

public sealed class User : BaseEntity
{
    #region Ctors

    private User(string firstName, string lastName, int age, int score=0)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.Score = score;
    }

    public User CreateUserWithOutScore(string firstName, string lastName, int age)
        => new User(firstName: firstName, lastName: lastName, age: age);

    public User CreateUserUser(string firstName, string lastName, int age, int score)
        => new User(firstName: firstName, lastName: lastName, age: age, score: score);

    #endregion
    #region Properties
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public int Age { get; private set; } = 0;
    public int Score { get; private set; } = 0;
    #endregion
    #region Methods
    public void SetFirstName(string firstName)
        => this.FirstName = firstName;
    public void SetLastName(string lastName)
        => this.LastName = LastName;
    public void SetAge(int age)
        => this.Age = age;
    public void SetScore(int score)
        => this.Score = score;
    #endregion
}
