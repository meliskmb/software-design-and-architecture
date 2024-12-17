from Car import Car
from Boost import Boost

class Mercedes(Car,Boost):
    def power(self):
        self.acceleration=7
    def turbo(self):
        self.acceleration*=2
        