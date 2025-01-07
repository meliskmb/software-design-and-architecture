from abc import ABC, abstractmethod

class IEmployee(ABC):
    @abstractmethod
    def show_info(self):
        pass