

public class SmartLight : SmartDevice
{
    public int Brightness;

    public SmartLight(string id, string name) : base(id, name)
    {
        Brightness = 50;
    }

    public override string GetStatus()
    {
        if (IsConnected) return $"{Name} Lights: On ({Brightness}%)";
        return $"{Name} Lights: Off";
    }

}
public class SmartThermostat : SmartDevice
{
    public double Temperature;

    public SmartThermostat(string id, string name) : base(id, name)
    {
        Temperature = 20;
    }
    public override string GetStatus()
    {
        if (IsConnected) return $"{Name} Thermostat: {Temperature} Celsius";
        return $"{Name} Thermostat: Off";
    }
}
