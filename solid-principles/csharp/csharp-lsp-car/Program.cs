using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YTM
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Ferrari ferrari = new Ferrari(0, 0);
            Console.WriteLine("FERRARI:");
            ferrari.Power();
            Console.WriteLine("The vehicle's initial speed: " + ferrari.GetVelocity());
            ferrari.Run();
            Console.WriteLine("The vehicle's speed after it started: " + ferrari.GetVelocity());
            ferrari.Boost();
            ferrari.Run();
            Console.WriteLine("The car's speed after the boost: " + ferrari.GetVelocity());
            ferrari.Open();
            ferrari.Run();
            Console.WriteLine("The car's speed after the AC is turned on: " + ferrari.GetVelocity());

            Mercedes mercedes = new Mercedes(0, 0);
            Console.WriteLine("MERCEDES:");
            mercedes.Power();
            Console.WriteLine("The vehicle's initial speed: " + mercedes.GetVelocity());
            mercedes.Run();
            Console.WriteLine("The vehicle's speed after it started: " + mercedes.GetVelocity());
            mercedes.Boost();
            mercedes.Run();
            Console.WriteLine("The car's speed after the boost: " + mercedes.GetVelocity());

            Tofas tofas = new Tofas(0, 0);
            Console.WriteLine("TOFAS:");
            tofas.Power();
            Console.WriteLine("The vehicle's initial speed: " + tofas.GetVelocity());
            tofas.Run();
            Console.WriteLine("The vehicle's speed after it started: " + tofas.GetVelocity());
            tofas.Open();
            tofas.Run();
            Console.WriteLine("The car's speed after the AC is turned on: " + tofas.GetVelocity());
        }
    }
}