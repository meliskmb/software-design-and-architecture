class Database():  
    def __init__(self):
        self.list = []
        self.check = False

    def get_list(self):
        return self.list

    def add_log(self, message: str):
        if self.check:
            self.list.append(message)

    def open_db(self):
        print("The database connection is open.")
        self.check = True

    def close_db(self):
        print("The database connection is closed.")
        self.check = False
