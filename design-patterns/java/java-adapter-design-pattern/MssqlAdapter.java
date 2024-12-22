// The MssqlAdapter class adapts the Mssql class to the DB interface.
public class MssqlAdapter implements DB{
    private Mssql mssql;

    public MssqlAdapter(){
        mssql = new Mssql();
    }

    @Override
    public User selectUserById(int id) {
       return mssql.userById(id);
    }

    @Override
    public void insertUser(User user) {
        mssql.user(user);
    }
   

}
