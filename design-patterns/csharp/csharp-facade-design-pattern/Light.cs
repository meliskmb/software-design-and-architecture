using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_facade
{
    public class Light
    {
        public void OnAll(){
            Console.WriteLine("All the lights have been turned on.");
        }

        public void OffAll(){
            Console.WriteLine("All the lights have been turned off.");
        }        
    }
}