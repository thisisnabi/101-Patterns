
using Thisisnabi.DesignPattern.Creational.Builder.MinimalAPIs.EndpointBuilders;

var builder = WebApplication.CreateSlimBuilder(args);

var services = builder.Services;
{
    services.SetupPersistence()
            .SetupSwagger()
            .SetupFluentValidation()
            .SetupMapster();
}


var app = builder.Build();
{
    app.UseSwagger();
    app.UseSwaggerUI();

    app.MapEntityEndpoints();

    app.Run();
}