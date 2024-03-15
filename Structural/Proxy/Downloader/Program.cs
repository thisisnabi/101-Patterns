

using Thisisnabi.DesignPattern.Structural.Proxy.Downloader;

// Usage example
class Program
{
    static void Main(string[] args)
    {
        RealVideoServer realServer = new RealVideoServer();
        ProxyVideoServer proxyServer = new ProxyVideoServer(realServer);

        proxyServer.GetVideo("image1.png"); // Download from real server and cache
        proxyServer.GetVideo("image1.png"); // Retrieve from cache

        proxyServer.GetVideo("image2.png"); // Download from real server and cache

        Console.ReadLine();
    }
}