public abstract class Car {
    protected int acceleration;
    protected int velocity;
    
    public Car(int acceleration, int velocity){
        this.acceleration = acceleration;
        this.velocity = velocity;
    }

    public int getAcceleration(){return this.acceleration;}
    public int getVelocity(){return this.velocity;}
    public void setAcceleration(int acceleration){this.acceleration = acceleration;}
    public void setVelocity(int velocity){this.velocity = velocity;}

    public abstract void power();
    public void run(){
        this.velocity += this.acceleration;
    }
}
