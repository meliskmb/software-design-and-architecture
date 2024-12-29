from Light import Light
from Door import Door
from TV import TV
from AirConditioning import AirConditioning

class Facade:
    def __init__(self):
        self.air_conditioner = AirConditioning()
        self.door = Door()
        self.light = Light()
        self.tv = TV()

    def turn_on_air_con(self):
        self.air_conditioner.on()

    def turn_off_air_con(self):
        self.air_conditioner.off()

    def adjust_air_con(self, degree):
        self.air_conditioner.adjust(degree)

    def unlock_door(self):
        self.door.unlock()

    def lock_door(self):
        self.door.lock()

    def turn_on_all_lights(self):
        self.light.on_all()

    def turn_off_all_lights(self):
        self.light.off_all()

    def turn_on_tv(self):
        self.tv.on()

    def turn_off_tv(self):
        self.tv.off()

    def sleep_mode(self):
        print("Activating sleep mode...")
        self.air_conditioner.off()
        self.door.lock()
        self.light.off_all()
        self.tv.off()
        print("Sleep mode activated!")
