namespace Thisisnabi.DesignPattern.Structural.Downloader;

public class RealVideoServer : IVideoServer
{
    public FileStream GetVideo(string path)
    {
        Console.WriteLine($"Downloading video file with ID {path} from the real server.");
        return new FileStream(path, FileMode.Open);
    }
}

