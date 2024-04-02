using System.Net;
/// <summary>
/// product
/// </summary>
public sealed class WebApplicationFramework
{ 
    public bool UseSSL { get; set; } = false;

    public HttpListener Listener { get; set; }

    internal void Run()
    {
        Listener.Start();
    }
}
