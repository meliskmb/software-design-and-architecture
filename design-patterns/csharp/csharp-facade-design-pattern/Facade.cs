using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_facade
{
    public class Facade
    {
        private AirConditioning airConditioner;
        private Door door;
        private Light light;
        private TV tv;

        public Facade(){
            airConditioner = new AirConditioning();
            door = new Door();
            light = new Light();
            tv = new TV();
        }


        public void TurnOnAirCon(){airConditioner.On();}
        public void TurnOffAirCon(){airConditioner.Off();}
        public void AdjustAirCon(int degree){airConditioner.Adjust(degree);}

        public void UnlockDoor(){door.Unlock();}
        public void LockDoor(){door.Lock();}

        public void TurnOnAllLights(){light.OnAll();}
        public void TurnOffAllLights(){light.OffAll();}

        public void TurnOnTv(){tv.On();}
        public void TurnOffTv(){tv.Off();}

        public void SleepMode(){
            Console.WriteLine("Activating sleep mode...");
            airConditioner.Off();
            door.Lock();
            light.OffAll();
            tv.Off();
            Console.WriteLine("Sleep mode activated!");
        }        
    }
}