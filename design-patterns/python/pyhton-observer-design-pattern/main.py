from User import User
from Group import Group
from Page import Page
from Post import Post

def main():
    user1 = User("user1")
    user2 = User("user2")

    group = Group("group")
    page = Page("page")

    user1.add_to_list(user2)
    user1.add_to_list(group)
    page.add_to_list(group)

    post1 = Post(user1, "post1")
    post2 = Post(page, "post2")

    user1.share(post1)
    page.share(post2)

if __name__ == "__main__":
    main()