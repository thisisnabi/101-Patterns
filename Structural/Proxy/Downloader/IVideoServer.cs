namespace Thisisnabi.DesignPattern.Structural.Proxy.Downloader;

/// <summary>
/// Interface defining the contract for video server functionalities.
/// </summary>
internal interface IVideoServer
{
    /// <summary>
    /// Fetches a video file from the server.
    /// </summary>
    /// <param name="path">The path or identifier of the video file.</param>
    /// <returns>A FileStream representing the downloaded video.</returns>
    FileStream GetVideo(string path);
}
