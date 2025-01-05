class Publisher():
    def __init__(self, name):
        self._name = name
        self.subscriber_list = []

    @property
    def name(self):
        return self._name
    @name.setter
    def name(self, name):
        self._name = name

    def add_to_list(self, subscriber):
        self.subscriber_list.append(subscriber)
    def remove_from_list(self, subscriber):
        self.subscriber_list.remove(subscriber)   
    def notify_all(self, post):
        for follower in self.subscriber_list:
            follower.notify(post)    
                 