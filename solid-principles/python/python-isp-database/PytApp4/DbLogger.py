from Logger import Logger
from Connection import Connection
from Database import Database

class DbLogger(Logger, Connection):  
    def __init__(self):
        self.database = Database()

    def write(self, message: str):
        self.database.add_log(message)

    def open_connection(self):
        self.database.open_db()

    def close_connection(self):
        self.database.close_db()
