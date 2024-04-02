using System.Text;

/// <summary>
/// Director
/// </summary>
public sealed class WebApplicationFrameworkDirector
{
    public WebApplicationFrameworkDirector()
    {

    }


    public async Task Construct()
    {
        var builder = WebApplicationFrameworkConcrete.CreateBuilder()
                                .IsEnabled()
                                .AddUrl("http://localhost:5019/");


        var app = builder.Build();
        app.Run();


        var httpContext = await app.Listener.GetContextAsync();
        var request = httpContext.Request;

        Console.WriteLine($"Received request for {request.Url}");

        var headers = request.Headers;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Headers:");
        foreach (string key in headers.Keys)
        {
            Console.WriteLine($"\t{key}: {headers[key]}");
        }

        using StreamReader streamReader = new(request.InputStream, Encoding.UTF8);

        var body = await streamReader.ReadToEndAsync();
        Console.ForegroundColor = ConsoleColor.Blue;

        Console.WriteLine(
                        $"""
                        body: {body}
                        """);

    }
}
