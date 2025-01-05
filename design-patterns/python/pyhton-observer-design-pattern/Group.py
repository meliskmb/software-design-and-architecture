from Subscriber import Subscriber

class Group(Subscriber):
    def __init__(self, name):
        self.name = name

    def notify(self, post):
        print(f"{self.name} => the user/page you are following ({post}) has shared: {post.content}")    