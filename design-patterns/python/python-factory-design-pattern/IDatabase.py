from abc import ABC,abstractmethod
class IDatabase(ABC):
    @abstractmethod
    def select_data(self):
        pass
    def insert_data(self):
        pass