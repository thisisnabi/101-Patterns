

using Thisisnabi.DesignPattern.Structural.Downloader;

RealVideoServer realServer = new RealVideoServer();
ProxyVideoServer proxyServer = new ProxyVideoServer(realServer);

proxyServer.GetVideo("image1.png");

proxyServer.GetVideo("image1.png");

proxyServer.GetVideo("image2.png");

Console.ReadLine();