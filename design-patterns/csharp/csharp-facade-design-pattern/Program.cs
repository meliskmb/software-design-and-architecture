using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_facade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Facade facade = new Facade();

            facade.TurnOnAirCon();
            facade.AdjustAirCon(25);
            facade.TurnOffAirCon();
            Console.WriteLine("--------");
            facade.SleepMode();
        }
    }
}
