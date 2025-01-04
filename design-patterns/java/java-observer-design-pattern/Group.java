public class Group implements Follower {
    private String name;

    public Group(String name) {
        this.name = name;
    }

    @Override
    public void notify(Post post) {
        System.out.println(this.name + " => the user/group you are following (" + post.toString() + ") has shared: " + post.getContent());
    }
}
