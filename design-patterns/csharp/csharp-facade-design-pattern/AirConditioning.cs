using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_facade
{
    public class AirConditioning
    {
        public void On(){
            Console.WriteLine("The air conditioning has been turned on.");
        }

        public void Off(){
            Console.WriteLine("The air conditioning has been turned off.");
        }  

        public void Adjust(int degree){
            Console.WriteLine("The air conditioning has been set to " + degree + " degrees.");
        }        
    }
}