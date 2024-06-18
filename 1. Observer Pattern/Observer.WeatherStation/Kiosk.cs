using Observer.WeatherStation.Abstractions;

namespace Observer.WeatherStation;

internal class Kiosk : IObserver
{
    private readonly string _ipAddress;
    public Kiosk(string ipAddress)
    {
        _ipAddress = ipAddress;
    }

    public void Update(IObservable obs)
    {
        if (obs is WeatherStationObservable workstation)
        {
            Console.WriteLine("Kiosk, {0},{1}", workstation.Temprature, _ipAddress);
        }
    }
}
