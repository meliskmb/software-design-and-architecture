public class MssqlYonetici extends DBYonetici {
    public  IDatabase getDatabase(){
        return new Mssql();
    }
}
