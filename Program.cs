using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convert_km_to_m
{
    class Program
    {
        public static double MeterToKilometer(double meter)
        {
            double Km = 0;

            Km = meter / 1000;

            return Km;
        }

        public static double KilometerToMeter(double km)
        {
            double METER = 0;

            METER = km * 1000;

            return METER;
        }

        static void Main()
        {
            double meter = 0;
            double km = 0;

            Console.Write("Enter the value of kilometer : ");
            km = double.Parse(Console.ReadLine());

            meter = KilometerToMeter(km);
            Console.WriteLine("Meter : " + meter + "m");

        }
    }
}

