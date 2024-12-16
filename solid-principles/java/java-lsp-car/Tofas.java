public class Tofas extends Car implements IKlima{
    public Tofas(int var1, int var2){
        super(var1, var2);
    }

    public void power(){
        this.acceleration = 5;
    }

    public void open(){
        this.acceleration *= 0.9;
    }
}
