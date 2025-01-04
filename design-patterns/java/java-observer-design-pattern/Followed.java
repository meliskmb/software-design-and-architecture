import java.util.ArrayList;
import java.util.List;

public class Followed {
    protected List<Follower> followerList;
    protected String name;

    public Followed(String name) {
        this.name = name;
        followerList = new ArrayList<>();
    }

    public void addFollower(Follower follower) {
        followerList.add(follower);
    }

    public void removeFollower(Follower follower) {
        followerList.remove(follower);
    }

    public void notifyAll(Post post) {
        for (Follower follower : followerList) {
            follower.notify(post);
        }
    }

    public String getName() {
        return name;
    }
}

