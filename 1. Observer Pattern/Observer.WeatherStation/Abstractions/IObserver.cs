namespace Observer.WeatherStation.Abstractions;
public interface IObserver
{
    public void Update(IObservable obs);
}