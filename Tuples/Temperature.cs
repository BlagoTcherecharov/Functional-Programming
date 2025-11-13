using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthlyTemperature
{
    class Program
    {
        static double AverageDailyTemperature(Tuple<int, int, double> weather)
        {
            return (weather.Item1 + weather.Item2) / 2;
        }

        static double AverageMonthlyTemperature(double[] average_daily_temperature)
        {
            double sum = 0;

            for (int i = 0; i < average_daily_temperature.Length; i++)
            {
                sum += average_daily_temperature[i];
            }

            return sum / average_daily_temperature.Length;
        }

        static double SumRain(double[] rain)
        {
            double sum = 0;

            for (int i = 0; i < rain.Length; i++)
            {
                sum += rain[i];
            }

            return sum;
        }

        static void Main(string[] args)
        {
            const int DAY_IN_MONTH = 30;

            Tuple<int, int, double>[] weather = new Tuple<int, int, double>[DAY_IN_MONTH];
            double[] average_daily_temperature = new double[DAY_IN_MONTH];
            double[] daily_rain = new double[DAY_IN_MONTH];

            var rand = new Random();

            for (int i = 0; i < DAY_IN_MONTH; i++)
            {
                int min = rand.Next(0, 20);
                int max = rand.Next(10, 40);
                double rain = rand.NextDouble();

                var current = weather[i];

                weather[i] = Tuple.Create(min, max, rain);

                average_daily_temperature[i] = AverageDailyTemperature(weather[i]);
                daily_rain[i] = weather[i].Item3;
            }
            
            double average_monthly_temperature = AverageMonthlyTemperature(average_daily_temperature);
            double sum_rain = SumRain(daily_rain);
            
            int min_temp = 20;
            int max_temp = 10;

            for (int i = 0; i < DAY_IN_MONTH; i++)
            {
                if (weather[i].Item1 < min_temp)
                    min_temp = weather[i].Item1;
                if (weather[i].Item2 > max_temp)
                    max_temp = weather[i].Item2;
            }

            Tuple<double, int, int, double> monthly_stats = new Tuple<double, int, int, double>(average_monthly_temperature, min_temp, max_temp, sum_rain);

            Console.WriteLine("Monthly stats:");
            Console.WriteLine("Average temperature: " + monthly_stats.Item1);
            Console.WriteLine("Minimal temperature: " + monthly_stats.Item2);
            Console.WriteLine("Maximal temperature: " + monthly_stats.Item3);
            Console.WriteLine("Total rain: " + monthly_stats.Item4);
        }
    }
}
