public class Post {
    private Followed followed;
    private String content;

    public Post(Followed followed, String content) {
        this.followed = followed;
        this.content = content;
    }

    public Followed getFollowed() {
        return followed;
    }

    public void setFollowed(Followed followed) {
        this.followed = followed;
    }

    public String getContent() {
        return content;
    }

    public void setContent(String content) {
        this.content = content;
    }

    @Override
    public String toString() {
        return this.followed.getName();
    }
}

