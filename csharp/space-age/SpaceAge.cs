public class SpaceAge
{
    int seconds = 0;
    int earthYearInSeconds = 31557600;
    public SpaceAge(int seconds)
    {
        this.seconds = seconds;
    }

    public double OnEarth()
    {
        return (double)this.seconds / (earthYearInSeconds * 1);
    }

    public double OnMercury()
    {
        return (double)this.seconds / (earthYearInSeconds * 0.2408467);
    }

    public double OnVenus()
    {
        return (double)this.seconds / (earthYearInSeconds * 0.61519726);
    }

    public double OnMars()
    {
        return (double)this.seconds / (earthYearInSeconds * 1.8808158);
    }

    public double OnJupiter()
    {
        return (double)this.seconds / (earthYearInSeconds * 11.862615);
    }

    public double OnSaturn()
    {
        return (double)this.seconds / (earthYearInSeconds * 29.447498);
    }

    public double OnUranus()
    {
        return (double)this.seconds / (earthYearInSeconds * 84.016846);
    }

    public double OnNeptune()
    {
        return (double)this.seconds / (earthYearInSeconds * 164.79132);
    }
}