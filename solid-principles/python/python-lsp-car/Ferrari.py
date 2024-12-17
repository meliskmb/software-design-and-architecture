from Car import Car
from AirConditioning import AirConditioning
from Boost import Boost

class Ferrari(Car,AirConditioning,Boost):
    def power(self):
        self.acceleration=10
    def turbo(self):
         self.acceleration*=2
    def open(self):
        self.acceleration*=0.9
             