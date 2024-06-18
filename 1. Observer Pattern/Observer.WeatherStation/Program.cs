// See https://aka.ms/new-console-template for more information
using Observer.WeatherStation;

Console.WriteLine("Hello, World!");

var workstation = new WeatherStationObservable();

workstation.Add(new Kiosk("8.7.5.3"));
workstation.Add(new Kiosk("22.11.22.33"));
workstation.Add(new TVRoom());

workstation.SetTemprature(10);

workstation.Add(new WallTV());

workstation.SetTemprature(13);
