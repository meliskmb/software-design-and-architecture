public class MysqlYonetici extends DBYonetici {
    public  IDatabase getDatabase(){
        return new Mysql();
    }
}
