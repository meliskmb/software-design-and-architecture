public class User {
    private String name;
    private String mail;
    private int ip;
    private int phoneNum;

    public User(String name, String mail, int ip, int phoneNum){
        this.name = name;
        this.mail = mail;
        this.ip = ip;
        this.phoneNum = phoneNum;
    }

    public void setName(String name){this.name = name;}
    public void setMail(String mail){this.mail = mail;}
    public void setIp(int ip){this.ip = ip;}
    public void setPhoneNum(int phoneNum){this.phoneNum = phoneNum;}

    public String getName(){return this.name;}
    public String getMail(){return this.mail;}
    public int getIp(){return this.ip;}
    public int getPhoneNum(){return this.phoneNum;}
}

