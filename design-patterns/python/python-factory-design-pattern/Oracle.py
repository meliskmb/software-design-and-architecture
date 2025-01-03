from IDatabase import IDatabase

class Oracle(IDatabase):
    def insert_data(self):
        print("Data insertion was successfully performed in Oracle.")
    def select_data(self):
        print("Data retrieval operation was successfully performed in Oracle.") 