from Car import Car
from AirConditioning import AirConditioning

class Tofas(Car,AirConditioning):
    def power(self):
        self.acceleration=5
    def open(self):
        self.acceleration*=0.9    