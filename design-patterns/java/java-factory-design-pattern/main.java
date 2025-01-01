public class main {
    public static void main(String[] args){
        MysqlYonetici mySqlYonetici = new MysqlYonetici();
        IDatabase mySql = mySqlYonetici.getDatabase();
        mySql.selectData();
        mySql.insertData();

        MssqlYonetici mssqlYonetici = new MssqlYonetici();
        IDatabase msSql = mssqlYonetici.getDatabase();
        msSql.selectData();
        msSql.insertData();

        OracleYonetici oracleYonetici = new OracleYonetici();
        IDatabase oracle = oracleYonetici.getDatabase();
        oracle.selectData();
        oracle.insertData();
    }
}
