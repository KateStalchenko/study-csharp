using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        var time = TimeSpan.FromSeconds(Math.Pow(10, 9));
        return moment.Add(time);
    }
}