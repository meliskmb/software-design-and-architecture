public class Mail implements Communication {
    public void sendInfo(User user, String message){
        this.sendMail(user.getMail(), message);
    }

    public void sendMail(String mail, String message){
        System.out.println("The message (" + message + ") has been sent to the " + mail + " email address.");
    }
}
