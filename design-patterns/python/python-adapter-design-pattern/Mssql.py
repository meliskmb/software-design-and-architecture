class Mssql():
    def __init__(self):
        self.id_counter = 0
        self.user_list = []

    def user_by_id(self, id):
        for user in self.user_list:
            if user.id == id:
                return user
        return None

    def user(self, user):
        self.id_counter += 1
        user.id = self.id_counter
        self.user_list.append(user)
