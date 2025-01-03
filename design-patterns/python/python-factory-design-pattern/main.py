from MysqlYonetici import MysqlYonetici
from MssqlYonetici import MssqlYonetici
from OracleYonetici import OracleYonetici

if __name__ == "__main__":
    mySqlYonetici = MysqlYonetici()  
    mySql = mySqlYonetici.get_database()  
    
    mySql.select_data()  
    mySql.insert_data()

    msSqlYonetici = MssqlYonetici()
    msSql = msSqlYonetici.get_database()

    msSql.select_data()
    msSql.insert_data()

    oracleYonetici = OracleYonetici()
    oracle = oracleYonetici.get_database()

    oracle.select_data()
    oracle.insert_data()