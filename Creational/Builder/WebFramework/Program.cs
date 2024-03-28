
using System.Net;

var builder = WebApplicationFrameworkBuilder.CreateBuilder()
                                            .IsEnabled()
                                            .AddUrl("https://localhost:443")
                                            .AddUrl("http://localhost:5001");


var app = builder.Build();
app.Run();

 
var httpContext = await app.Listener.GetContextAsync();

 

public class WebApplicationFramework
{ 
    public bool UseSSL { get; set; } = false;

    public HttpListener Listener { get; set; }

    internal void Run()
    {
        Listener.Start();
    }
}

public interface IWebApplicationFrameworkBuilder
{
    IWebApplicationFrameworkBuilder AddUrl(string url);
    IWebApplicationFrameworkBuilder IsEnabled(bool enabled = true);

    WebApplicationFramework Build();
}

public class WebApplicationFrameworkBuilder : IWebApplicationFrameworkBuilder
{
    private bool isEnableSSL;
    private IList<string> Urls = new List<string>();

    public static WebApplicationFrameworkBuilder CreateBuilder()
    {
        return new WebApplicationFrameworkBuilder();
    }


    public IWebApplicationFrameworkBuilder AddUrl(string url)
    {
        Urls.Add(url);
        return this;
    }

    public IWebApplicationFrameworkBuilder IsEnabled(bool enabled = true)
    {
        isEnableSSL = enabled;
        return this;
    }

    public WebApplicationFramework Build()
    {
        if (Urls.Count == 0)
            throw new Exception("Invalid urls.");

        var ls = new HttpListener();
 

        foreach (var url in Urls)
        {
            ls.Prefixes.Add(url);
        }
         
        return new WebApplicationFramework
        {
            UseSSL = isEnableSSL,
            Listener = ls,


        };
    }
}