class User():
    def __init__(self, name, id=None):
        self._name = name
        self._id = id

    # Getters and Setters
    @property
    def name(self):
        return self._name
    @name.setter
    def name(self, name):
        self._name = name    

    @property
    def id(self):
        return self._id
    @id.setter
    def id(self, id):
        self._id = id

    