public class main{
    public static void main(String[] args){
        Ferrari ferrari = new Ferrari(0, 0);
        System.out.println("FERRARI:");
        ferrari.power();
        System.out.println("The vehicle's initial speed: " + ferrari.getVelocity());
        ferrari.run();
        System.out.println("The vehicle's speed after it started: " + ferrari.getVelocity());
        ferrari.boost();
        ferrari.run();
        System.out.println("The car's speed after the boost: " + ferrari.getVelocity());
        ferrari.open();
        ferrari.run();
        System.out.println("The car's speed after the AC is turned on: " + ferrari.getVelocity());


        Mercedes mercedes = new Mercedes(0, 0);
        System.out.println("MERCEDES:");
        mercedes.power();
        System.out.println("The vehicle's initial speed: " + mercedes.getVelocity());
        mercedes.run();
        System.out.println("The vehicle's speed after it started: " + mercedes.getVelocity());
        mercedes.boost();
        mercedes.run();
        System.out.println("The car's speed after the boost: " + mercedes.getVelocity());

        Tofas tofas = new Tofas(0, 0);
        System.out.println("TOFAS:");
        tofas.power();
        System.out.println("The vehicle's initial speed: " + tofas.getVelocity());
        tofas.run();
        System.out.println("The vehicle's speed after it started: " + tofas.getVelocity());
        tofas.open();
        tofas.run();
        System.out.println("The car's speed after the AC is turned on: " + tofas.getVelocity());

    }
}    
