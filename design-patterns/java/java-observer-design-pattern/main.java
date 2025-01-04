public class main {
    public static void main(String[] args) {
        User user1 = new User("user1");
        User user2 = new User("user2");

        Group group = new Group("group");

        Page page = new Page("page");

        user1.addFollower(user2);
        user1.addFollower(group);
        page.addFollower(group);

        Post post1 = new Post(user1, "post1");
        Post post2 = new Post(page, "post2");

        user1.share(post1);
        page.share(post2);
    }
}
