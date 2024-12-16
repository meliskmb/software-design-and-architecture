class User:
    def __init__(self, name = None, mail = None, ip = None, phone_number = None):
        self.name = name
        self.mail = mail
        self.ip = ip
        self.phone_number = phone_number

    def set_name(self, name):
        self.name = name    
    def set_mail(self, mail):
        self.mail = mail    
    def set_ip(self, ip):
        self.ip = ip    
    def set_phone_number(self, phone_number):
        self.phone_number = phone_number 

    def get_name(self):
        return self.name       
    def get_mail(self):
        return self.mail      
    def get_ip(self):
        return self.ip       
    def get_phone_number(self):
        return self.phone_number       