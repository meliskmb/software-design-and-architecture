from abc import ABC,abstractmethod

class AirConditioning(ABC):
    @abstractmethod
    def open(self):
        pass