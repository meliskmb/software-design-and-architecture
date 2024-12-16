public class Mercedes extends Car implements ITurbo {
    public Mercedes(int var1, int var2){
        super(var1, var2);
    }

    public void power(){
        this.acceleration = 7;
    }

    public void boost(){
        this.acceleration *= 2;
    }
}
