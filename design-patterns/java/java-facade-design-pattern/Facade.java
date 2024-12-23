// Facade class provides a simplified interface to control multiple subsystems (AirConditioning, Door, Light, TV).
public class Facade {
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


    public void turnOnAirCon(){airConditioner.on();}
    public void turnOffAirCon(){airConditioner.off();}
    public void adjustAirCon(int degree){airConditioner.adjust(degree);}

    public void unlockDoor(){door.unlock();}
    public void lockDoor(){door.lock();}

    public void turnOnAllLights(){light.onAll();}
    public void turnOffAllLights(){light.offAll();}

    public void turnOnTv(){tv.on();}
    public void turnOffTv(){tv.off();}

    public void sleepMode(){
        System.out.println("Activating sleep mode...");
        airConditioner.off();
        door.lock();
        light.offAll();
        tv.off();
        System.out.println("Sleep mode activated!");
    }
}
