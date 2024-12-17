from abc import ABC,abstractmethod 

class Car(ABC):
    def __init__(self):
        self.acceleration=0
        self.velocity=0
    @abstractmethod
    def power(self):
        pass
    def run(self):
        self.velocity+= self.acceleration

    def get_velocity(self):
        return self.velocity

    def get_acceleration(self):
        return self.acceleration

         