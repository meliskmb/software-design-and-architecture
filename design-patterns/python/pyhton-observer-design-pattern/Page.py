from Publisher import Publisher

class Page(Publisher):
    def __init__(self, name):
        super().__init__(name)

    def share(self, post):
        self.notify_all(post)