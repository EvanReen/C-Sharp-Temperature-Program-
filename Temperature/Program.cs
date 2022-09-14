﻿public class Temperature
{
    private decimal temp;

    public Temperature(decimal temperature)
    {
        this.temp = temperature;
    }

    public override string ToString()
    {
        return this.temp.ToString("N1") + "°C";
    }
}

public class Display
{
    public static void Main()
    {
        Temperature currentTemperature = new Temperature(23.6m);
        Console.WriteLine($"The current temperature is {currentTemperature}");
    }
}
