public static class Manager
{
    public static List<SmartDevice> ListDevices = new();

    public static void AddDevice(SmartDevice device)
    {
        ListDevices.Add(device);
    }
    public static void ToggleDevice(string deviceId)
    {
        foreach (var device in ListDevices)
        {
            if (device.Id == deviceId)
            {
                device.TurnPower();
                break;
            }
        }
    }
    public static void PrintStatus()
    {
        Console.WriteLine("Device Status:");
        foreach (var device in ListDevices)
        {
            Console.WriteLine(device.GetStatus());
        }
        Console.WriteLine(" ");
    }
    public static SmartDevice FindDevice(string deviceId)
    {
        foreach (var device in ListDevices)
        {
            if (device.Id == deviceId)
            {
                return device;
            }
        }
        return null;
    }
}