from Logger import Logger

class ConsoleLogger(Logger):
    def write(self,message:str):
        print(message)