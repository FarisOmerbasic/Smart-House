
public abstract class SmartDevice
{
    public string Id { get; }
    public string Name { get; }
    public bool IsConnected { get; set; }


    public SmartDevice(string id, string name)
    {
        Id = id;
        Name = name;
    }
    public void TurnPower()
    {
        if (IsConnected) TurnOff();
        else TurnOn();
    }
    public void TurnOn()
    {
        if (!IsConnected)
        {
            IsConnected = true;

        }
    }
    public void TurnOff()
    {
        if (IsConnected)
        {
            IsConnected = false;

        }
    }

    public abstract string GetStatus();
}