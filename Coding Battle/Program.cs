

class Program
{
    static void Main()
    {
        Manager.AddDevice(new SmartLight("L", "Children Rooms"));
        Manager.AddDevice(new SmartThermostat("T", "Temperature on"));

        while (true)
        {
            Console.WriteLine("Smart House");
            Console.WriteLine("1 Display Device Status");
            Console.WriteLine("2. Toggle Device");
            Console.WriteLine("3. Change Device Settings");
            Console.WriteLine("4. Leave");
            Console.Write("Choose option from above: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Manager.PrintStatus();
            }
            else if (choice == "2")
            {
                Console.Write("Enter Device Id");
                string deviceId = Console.ReadLine();
                Manager.ToggleDevice(deviceId);
                Console.WriteLine("Device is toggled");
            }
            else if (choice == "3")
            {
                Console.Write("Enter Device Id");
                string deviceId = Console.ReadLine();

                var device = Manager.FindDevice(deviceId);
                if (device == null)
                {
                    Console.WriteLine("Device is not found");
                }
                else if (device is SmartLight light)
                {
                    Console.Write("Enter Brightness from 0 100: ");
                    int brightness = int.Parse(Console.ReadLine());
                    light.Brightness = brightness;
                    Console.WriteLine("Brightness is set");
                }
                else if (device is SmartThermostat thermostat)
                {
                    Console.Write("Enter temperature from 5 to 35:");
                    double temp = double.Parse(Console.ReadLine());
                    thermostat.Temperature = temp;
                    Console.WriteLine("Temperature is updated");

                }
                else
                {
                    Console.WriteLine("This device has no settings to adjust");
                }
            }
            else if (choice == "4")
            {
                Console.WriteLine("Exit");
                break;
            }
            else
            {
                Console.WriteLine("Error");
            }

        }
    }
}