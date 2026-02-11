class RemoteControlCar
{
    int distance = 0;
    int batteryPercent = 100;
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {distance} meters";
    }

    public string BatteryDisplay()
    {
        string display = batteryPercent > 0 ? $"Battery at {batteryPercent}%" : "Battery empty";
        return display;
    }

    public void Drive()
    {
        if (batteryPercent <= 0) return;
        distance += 20;
        batteryPercent -= 1;

    }
}
