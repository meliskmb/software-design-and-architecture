from User import User
from Alert import Alert

if __name__ == "__main__":
    user = User("user", "user@gmail.com", 00000, 1)
    alert = Alert()
    alert.notify(user, "test message")
