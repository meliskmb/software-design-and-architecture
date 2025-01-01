public class OracleYonetici extends DBYonetici {
    public  IDatabase getDatabase(){
        return new Oracle();
    }
}
