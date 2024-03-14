namespace Thisisnabi.DesignPattern.Structural.Proxy.Downloader;

internal interface IVideoServer
{
    FileStream GetVideo(string path);
}
