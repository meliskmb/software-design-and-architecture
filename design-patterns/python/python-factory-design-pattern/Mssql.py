from IDatabase import IDatabase

class Mssql(IDatabase):
    def insert_data(self):
        print("Data insertion was successfully performed in Mssql.")
    def select_data(self):
        print("Data retrieval operation was successfully performed in Mssql.") 