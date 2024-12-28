# A service layer to perform database operations using the DB interface.
class Service():
    def __init__(self, db):
        self._db = db

    @property
    def db(self):
        return self._db
    @db.setter
    def db(self, db):
        self._db = db

    def add_user(self, user):
        self._db.insert_user(user)

    def get_user(self, id):
        return self._db.select_user_by_id(id)          