public class User extends Followed implements Follower {

    public User(String name) {
        super(name);
    }

    public void share(Post post) {
        this.notifyAll(post);
    }

    @Override
    public void notify(Post post) {
        System.out.println(this.name + " => the user/group you are following (" + post.toString() + ") has shared: " + post.getContent());
    }
}
