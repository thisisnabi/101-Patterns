
using System.Net;
/// <summary>
/// concrete builder
/// </summary>
public sealed class WebApplicationFrameworkConcrete : IWebApplicationFrameworkBuilder
{
    private bool isEnableSSL;
    private IList<string> Urls = new List<string>();

    public static WebApplicationFrameworkConcrete CreateBuilder()
    {
        return new WebApplicationFrameworkConcrete();
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