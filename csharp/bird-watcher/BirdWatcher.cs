class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return [0, 2, 5, 3, 7, 8, 4];
    }

    public int Today()
    {
        return this.birdsPerDay[this.birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
        int todayIndex = this.birdsPerDay.Length - 1;
        this.birdsPerDay[todayIndex]++;
    }

    public bool HasDayWithoutBirds()
    {

        foreach (int count in this.birdsPerDay)
        {
            if (count == 0) return true;
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int result = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            result += this.birdsPerDay[i];
        }
        return result;
    }

    public int BusyDays()
    {
        int busyDays = 0;
        foreach (int count in this.birdsPerDay)
        {
            if (count > 4) busyDays++;
        }
        return busyDays;
    }
}