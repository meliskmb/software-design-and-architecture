public interface DB {
    User selectUserById(int id);
    void insertUser(User user);
}
