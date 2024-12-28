from abc import ABC, abstractmethod

class DB(ABC):
    @abstractmethod
    def select_user_by_id(self, id):
        pass
    @abstractmethod
    def insert_user(self, user):
        pass