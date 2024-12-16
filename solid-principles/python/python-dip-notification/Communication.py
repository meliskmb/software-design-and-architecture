from abc import ABC , abstractmethod

class Communication(ABC):
    @abstractmethod
    def send_info(self, user, message):
        pass