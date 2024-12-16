from abc import ABC , abstractmethod
from Communication import Communication
from User import User

class Mail(Communication):
    def send_info(self, user, message):
        self.send_mail(user.get_mail(), message)
    def send_mail(self, mail, message):
        print(f"The message ({message}) has been sent to the mail {mail} email address.")    

        