using Observer.WeatherStation.Abstractions;

namespace Observer.WeatherStation;

internal class WallTV : IObserver
{
    public void Update(IObservable obs)
    {
        if (obs is WeatherStationObservable workstation)
        {
            Console.WriteLine("WallTV, {0}", workstation.Temprature);
        }
    }
}
