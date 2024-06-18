namespace Observer.WeatherStation.Abstractions;
public interface IObservable
{
    void Add(IObserver observer);
    void Remove(IObserver observer);
    void Notify();

}

