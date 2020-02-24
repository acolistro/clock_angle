using System;
using System.Collections.Generic;

public class Clock
{
    public int Hour;
    public int Min;

    public Clock(int hour, int min)
    {
        Hour = hour;
        Min = min;
    }
    public void CalculateAngle(int hr, int mins)
    {
        int multHour = hr * 30;
        int multMin = mins * 6;
        int diff = Math.Abs(multHour - multMin);
        Console.WriteLine(diff + " degrees");
    }
}

public class Program 
{
    public static void Main()
    {
        
        Console.WriteLine("Please enter an Hour");
        string hour = Console.ReadLine();
        int newHour = int.Parse(hour);

        Console.WriteLine("Please enter Mins");
        string mins = Console.ReadLine();
        int newMins = int.Parse(mins);

        Clock findTime = new Clock(newHour, newMins);
        findTime.CalculateAngle(newHour, newMins);
    }
}