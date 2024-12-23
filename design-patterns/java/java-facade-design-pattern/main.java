public class main{
    public static void main(String[] args){
        Facade facade = new Facade();

        facade.turnOnAirCon();
        facade.adjustAirCon(25);
        facade.turnOffAirCon();
        System.out.println("--------");
        facade.sleepMode();

    }
}    
