using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_facade
{
    public class Door
    {
        public void Lock(){
            Console.WriteLine("The door has been locked.");
        }

        public void Unlock(){
            Console.WriteLine("The door has been unlocked.");
        }        
    }
}