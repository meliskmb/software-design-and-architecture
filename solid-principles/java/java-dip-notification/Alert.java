import java.util.ArrayList;
import java.util.List;

public class Alert {
    private Mail mail;
    private Notification notification;
    private List<Communication> comList;

    public Alert(){
        comList = new ArrayList<>();
        mail = new Mail();
        notification = new Notification();
        comList.add(notification);
        comList.add(mail);

    }

    public void notify(User user, String message){
        for (Communication communication : comList) {
            communication.sendInfo(user, message);
        }
    }
    
}
