from abc import ABC , abstractmethod

class Logger(ABC):
   @abstractmethod
   def write(self,message:str):
      pass 