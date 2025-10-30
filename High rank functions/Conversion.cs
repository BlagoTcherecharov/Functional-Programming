using System;

public class ConversionValues
{
    public static void Conversion(double meter, Action<double> f1)
    {
        f1(meter);
    }
    
    public static void MeterToKilometer(double meter)
    {
        Console.WriteLine($"{meter}m = {meter/1000}km");
    }
    
    public static void KilometerToMeter(double km)
    {
        Console.WriteLine($"{km}km = {km*1000}m");
    }
    
    public static void HourToMinute(double hour)
    {
        Console.WriteLine($"{hour}h = {hour*60}min");
    }
    
    public static void MinuteToHour(double minute)
    {
        Console.WriteLine($"{minute}min = {minute/60}h");
    }
    
    public static void HourToSecond(double hour)
    {
        Console.WriteLine($"{hour}h = {hour*3600}s");
    }
    
    public static void SecondToHour(double second)
    {
        Console.WriteLine($"{second}s = {second/3600}h");
    }
    
    public static void MeterSecondToKilometerHour(double meterSecond)
    {
        Console.WriteLine($"{meterSecond}m/s = {meterSecond*3.6}km/h");
    }
    
    public static void KilometerHourToMeterSecond(double kmHour)
    {
        Console.WriteLine($"{kmHour}km/h = {kmHour/3.6}m/s");
    }
    
    public static void KilometerHourToMilesHour(double kmHour)
    {
        Console.WriteLine($"{kmHour}km/h = {kmHour*0.621371}miles/h");
    }
    
    public static void MilesHourToKilometerHour(double milesHour)
    {
        Console.WriteLine($"{milesHour}miles/h = {milesHour/0.621371}km/h");
    }
    
    public static void Main(string[] args)
    {
        Console.Write("Meter to kilometer conversion: ");
        double meter = Convert.ToDouble(Console.ReadLine());
        Conversion(meter, MeterToKilometer);
        
        Console.Write("Kilometer to meter conversion: ");
        double km = Convert.ToDouble(Console.ReadLine());
        Conversion(km, KilometerToMeter);
        
        Console.Write("Hour to minute conversion: ");
        double hour = Convert.ToDouble(Console.ReadLine());
        Conversion(hour, HourToMinute);
        Conversion(hour, HourToSecond);
        
        Console.Write("Minute to hour conversion: ");
        double minute = Convert.ToDouble(Console.ReadLine());
        Conversion(minute, MinuteToHour);
        
        Console.Write("Second to hour conversion: ");
        double second = Convert.ToDouble(Console.ReadLine());
        Conversion(second, SecondToHour);
        
        Console.Write("M/s to km/h conversion: ");
        double meterSecond = Convert.ToDouble(Console.ReadLine());
        Conversion(meterSecond, MeterSecondToKilometerHour);
        
        Console.Write("Km/h to miles/h conversion: ");
        double kmHour = Convert.ToDouble(Console.ReadLine());
        Conversion(kmHour, KilometerHourToMeterSecond);
        Conversion(kmHour, KilometerHourToMilesHour);
        
        Console.Write("Miles/h to km/h conversion: ");
        double milesHour = Convert.ToDouble(Console.ReadLine());
        Conversion(milesHour, MilesHourToKilometerHour);
    }
}
