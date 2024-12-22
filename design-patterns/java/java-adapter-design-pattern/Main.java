public class Main {
    public static void main(String[] args) {
        
        MssqlAdapter mssqlAdapter = new MssqlAdapter();
        Service service = new Service(mssqlAdapter);

        service.addUser(new User("User1"));
        User user1 = service.getUser(0);
        service.addUser(new User("User2"));
        User user2 = service.getUser(1);
        service.addUser(new User("User3"));
        User user3 = service.getUser(2);

        System.out.println(user1.getName());
        System.out.println(user2.getName());
        System.out.println(user3.getName());
    }
}