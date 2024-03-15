namespace Thisisnabi.DesignPattern.Structural.Proxy.Downloader;

/// <summary>
/// The actual video server implementation responsible for downloading video files.
/// </summary>
public class RealVideoServer : IVideoServer
{
    /// <summary>
    /// Downloads a video file from the real server.
    /// (Simulates the download process)
    /// </summary>
    /// <param name="path">The path or identifier of the video file.</param>
    /// <returns>A FileStream representing the downloaded video.</returns>
    public FileStream GetVideo(string path)
    {
        Console.WriteLine($"Downloading video file with ID {path} from the real server.");
        return new FileStream(path, FileMode.Open);
    }
}