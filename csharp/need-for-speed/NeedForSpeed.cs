class RemoteControlCar
{
    int speed;
    int batteryDrain;
    int batteryLife = 100;
    int distanceDriven = 0;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public int BatteryDrain
    {
        get { return batteryDrain; }
        set { batteryDrain = value; }
    }

    public int BatteryLife
    {
        get { return batteryLife; }
        set { batteryLife = value; }
    }

    public bool BatteryDrained()
    {
        return batteryLife < batteryDrain;
    }

    public int DistanceDriven()
    {
        return distanceDriven;
    }

    public void Drive()
    {
        if (this.BatteryDrained()) return;
        this.distanceDriven += speed;
        this.batteryLife -= batteryDrain;
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    int distance;
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        return ((car.Speed * (car.BatteryLife / car.BatteryDrain)) - distance) >= 0;
    }
}
