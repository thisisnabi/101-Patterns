namespace Thisisnabi.DesignPattern.Structural.Proxy.Downloader;

/// <summary>
/// Proxy class that acts as an intermediary between the client and the real video server.
/// </summary>
public class ProxyVideoServer : IVideoServer
{
    private readonly RealVideoServer _realServer; // Use proper naming convention
    private readonly Dictionary<string, FileStream> _videoCache; // Use proper naming convention

    /// <summary>
    /// Initializes a new instance of the ProxyVideoServer class.
    /// </summary>
    /// <param name="realServer">The real video server object to be proxied.</param>
    public ProxyVideoServer(RealVideoServer realServer)
    {
        _realServer = realServer;
        _videoCache = new Dictionary<string, FileStream>();
    }

    /// <summary>
    /// Retrieves a video file from the server, utilizing caching for efficiency.
    /// </summary>
    /// <param name="path">The path or identifier of the video file.</param>
    /// <returns>A FileStream representing the downloaded video.</returns>
    public FileStream GetVideo(string path)
    {
        if (_videoCache.ContainsKey(path))
        {
            Console.WriteLine($"Retrieving video file {path} from cache.");
            return _videoCache[path];
        }
        else
        {
            FileStream videoFile = _realServer.GetVideo(path);
            Console.WriteLine($"Downloading video file {path} from the real server and caching it.");
            _videoCache[path] = videoFile;
            return videoFile;
        }
    }
}