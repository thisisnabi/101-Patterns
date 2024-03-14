
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Model;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Providers;


// Create the request handlers
var validationHandler = new ValidationHandler();
var authenticationHandler = new AuthenticationHandler();
var authorizationHandler = new AuthorizationHandler();



// Set the chain of responsibility
validationHandler.SetNextHandler(authenticationHandler);
authenticationHandler.SetNextHandler(authorizationHandler);


// Create a request
var request = new Request { Username = "hwpro"  , Password = "123"};


// Process the request
validationHandler.HandleRequest(request);


Console.ReadLine();
