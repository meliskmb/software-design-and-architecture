from DbLogger import DbLogger
from ConsoleLogger import ConsoleLogger

class Main:
    def __init__(self):
        self.db_logger=DbLogger()
        self.console_logger=ConsoleLogger()


    def run(self):
        self.db_logger.write("Log 1") 
        self.db_logger.open_connection()
        self.db_logger.write("Log 2")

        self.console_logger.write("Log 3")
        self.db_logger.write("Log 4")
        self.db_logger.close_connection()
        self.db_logger.write("Log 5")

        for message in self.db_logger.database.get_list():
            print(message)    

if __name__=="__main__":
    app=Main()
    app.run()
         