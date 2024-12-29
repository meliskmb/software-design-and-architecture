from Facade import Facade

if __name__ == "__main__":
    facade = Facade()

    facade.turn_on_air_con()
    facade.adjust_air_con(25)
    facade.turn_off_air_con()
    print("--------")
    facade.sleep_mode()