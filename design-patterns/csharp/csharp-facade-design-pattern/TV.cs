using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_facade
{
    public class TV
    {
        public void On(){
            Console.WriteLine("The TV has been turned on.");
        }

        public void Off(){
            Console.WriteLine("The TV has been turned off.");
        }
    }
}