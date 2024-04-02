/// <summary>
/// builder
/// </summary>
public interface IWebApplicationFrameworkBuilder
{
    IWebApplicationFrameworkBuilder AddUrl(string url);
    IWebApplicationFrameworkBuilder IsEnabled(bool enabled = true);

    WebApplicationFramework Build();
}
