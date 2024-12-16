public class main{
    public static void main(String[] args){
        User user = new User("user1", "user1@gmail.com", 111, 0000);
        Alert alert = new Alert();
                alert.notify(user, "test message");

    }
}