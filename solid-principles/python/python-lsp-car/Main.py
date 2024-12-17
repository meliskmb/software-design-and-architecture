
from Ferrari import Ferrari
from Mercedes import Mercedes
from Tofas import Tofas

def main():
    ferrari=Ferrari()
    print("FERRARI:")
    ferrari.power()
    print("The vehicle's initial speed: ", ferrari.get_velocity())
    ferrari.run()
    print("The vehicle's speed after it started: ",ferrari.get_velocity())
    ferrari.turbo()
    ferrari.run()
    print("The car's speed after the boost: ", ferrari.get_velocity())
    ferrari.open()
    ferrari.run()
    print("The car's speed after the AC is turned on: ", ferrari.get_velocity())

    mercedes=Mercedes()
    print("MERCEDES:")
    mercedes.power()
    print("The vehicle's initial speed: ", mercedes.get_velocity())
    mercedes.run()
    print("The vehicle's speed after it started: ",mercedes.get_velocity())
    mercedes.turbo()
    mercedes.run()
    print("The car's speed after the boost: ", mercedes.get_velocity())

    tofas=Tofas()
    print("TOFAS:")
    tofas.power()
    print("The vehicle's initial speed: ", tofas.get_velocity())
    tofas.run()
    print("The vehicle's speed after it started: ",tofas.get_velocity())
    tofas.open()
    tofas.run()
    print("The car's speed after the AC is turned on: ", tofas.get_velocity())



if __name__ == '__main__' :
    main()   