public class Notification implements Communication {
    public void sendInfo(User user, String message){
        this.sendNotification(user.getIp(), message);
    }

    public void sendNotification(int ip, String message){
        System.out.println("The message (" + message + ") has been sent to the adress: " + ip);
    }
}
