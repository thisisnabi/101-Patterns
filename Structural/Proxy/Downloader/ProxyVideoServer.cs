namespace Thisisnabi.DesignPattern.Structural.Downloader;

public class ProxyVideoServer : IVideoServer
{
    private readonly RealVideoServer realServer;
    private readonly Dictionary<string, FileStream> videoCache;

    public ProxyVideoServer(RealVideoServer realServer)
    {
        this.realServer = realServer;
        this.videoCache = new Dictionary<string, FileStream>();
    }

    public FileStream GetVideo(string path)
    {
        if (videoCache.ContainsKey(path))
        {
            Console.WriteLine($"Retrieving video file {path} from cache.");
            return videoCache[path];
        }
        else
        {
            FileStream videoFile = realServer.GetVideo(path);
            Console.WriteLine($"Caching video file {path}.");
            videoCache[path] = videoFile;
            return videoFile;
        }
    }
}
