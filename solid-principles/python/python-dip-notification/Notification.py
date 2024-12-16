from Communication import Communication
from User import User

class Notification(Communication):
    def send_info(self, user, message):
        self.send_notification(user.get_ip(), message)
    def send_notification(self, ip, message):
        print(f"The message ({message}) has been sent to the address: {ip}")    


