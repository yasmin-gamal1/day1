using System;

public class Duration
{
   
    private int hours;
    private int minutes;
    private int seconds;

    
    public Duration(int hours, int minutes, int seconds)
    {
        this.hours = hours;
        this.minutes = minutes;
        this.seconds = seconds;
    }

    
    public Duration(int totalSeconds)
    {
        this.hours = totalSeconds / 3600;
        totalSeconds %= 3600;
        this.minutes = totalSeconds / 60;
        this.seconds = totalSeconds % 60;
    }

    
    public string GetString()
    {
        if (hours > 0)
        {
            return $"Hours: {hours}, Minutes: {minutes}, Seconds: {seconds}";
        }
        else if (minutes > 0)
        {
            return $"Minutes: {minutes}, Seconds: {seconds}";
        }
        else
        {
            return $"Seconds: {seconds}";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Duration D1 = new Duration(1, 10, 15);
        Console.WriteLine(D1.GetString()); 

        Duration D2 = new Duration(3600);
        Console.WriteLine(D2.GetString()); 

        Duration D3 = new Duration(7800);
        Console.WriteLine(D3.GetString()); 

        Duration D4 = new Duration(666);
        Console.WriteLine(D4.GetString());  
    }
}
