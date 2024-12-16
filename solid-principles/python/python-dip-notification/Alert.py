from Mail import Mail
from Notification import Notification
from User import User

class Alert:
    def __init__(self):
        self.communication_list = []
        self.mail = Mail()
        self.notification = Notification()
        self.communication_list.append(self.mail)
        self.communication_list.append(self.notification)

    def notify(self, user, message):
        for communication in self.communication_list:
            communication.send_info(user, message)