from DB import DB
from Mssql import Mssql

# The MssqlAdapter class adapts the Mssql class to the DB interface.
class MssqlAdapter(DB):
    def __init__(self):
        self.mssql = Mssql()

    def select_user_by_id(self, id):
        return self.mssql.user_by_id(id)

    def insert_user(self, user):
        self.mssql.user(user)    
