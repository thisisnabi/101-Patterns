namespace Thisisnabi.DesignPattern.Structural.Downloader;

internal interface IVideoServer
{
    FileStream GetVideo(string path);
}
