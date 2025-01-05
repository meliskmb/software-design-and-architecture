from Subscriber import Subscriber
from Publisher import Publisher

class User(Subscriber, Publisher):
    def __init__(self, name):
        super().__init__(name)

    def share(self, post):
        self.notify_all(post)

    def notify(self, post):
        print(f"{self.name} => the user/page you are following ({post}) has shared: {post.content}")