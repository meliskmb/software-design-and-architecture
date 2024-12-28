from DB import DB

class Oracle(DB):
    def __init__(self):
        self.id_counter = 0
        self.user_list = []

    def select_user_by_id(self, id):
        for user in self.user_list:
            if user.id == id:
                return user
        return None
    
    def insert_user(self, user):
        self.count()
        user.id = self.id_counter
        self.user_list.append(user)

    
    def count(self):
        self.id_counter += 1