public class Page extends Followed {

    public Page(String name) {
        super(name);
    }

    public void share(Post post) {
        this.notifyAll(post);
    }
}

