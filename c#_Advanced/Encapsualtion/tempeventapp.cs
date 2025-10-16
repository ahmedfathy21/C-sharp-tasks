using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class TemperatureChangedEventArgs : EventArgs
{
    public double OldTemperature { get; }
    public double NewTemperature { get; }

    public TemperatureChangedEventArgs(double oldTemp, double newTemp)
    {
        OldTemperature = oldTemp;
        NewTemperature = newTemp;
    }
}

public class Thermostat
{
    public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

    private double _temperature;
    public double Temperature
    {
        get => _temperature;
        set
        {
            if (_temperature != value)
            {
                var oldTemp = _temperature;
                _temperature = value;
                OnTemperatureChanged(oldTemp, value);
            }
        }
    }

    protected virtual void OnTemperatureChanged(double oldTemp, double newTemp)
    {
        TemperatureChanged?.Invoke(this, new TemperatureChangedEventArgs(oldTemp, newTemp));
    }
}

// Usage
public class Program
{
    public static void Main(string[] args)
    {
        var thermostat = new Thermostat();

        thermostat.TemperatureChanged += (sender, e) =>
        {
            Console.WriteLine($"Temp changed from {e.OldTemperature}°C to {e.NewTemperature}°C");
        };

        thermostat.Temperature = 25; // Triggers event
    }
}