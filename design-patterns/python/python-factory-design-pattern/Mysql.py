from IDatabase import IDatabase

class Mysql(IDatabase):
    def insert_data(self):
        print("Data insertion was successfully performed in Mysql.")
    def select_data(self):
        print("Data retrieval operation was successfully performed in Mysql.") 