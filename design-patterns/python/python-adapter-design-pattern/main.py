from MssqlAdapter import MssqlAdapter
from Service import Service
from User import User

if __name__ == "__main__":
    mssql_adapter = MssqlAdapter()
    service = Service(mssql_adapter)

    service.add_user(User("user1"))
    
    user1 = service.get_user(1)
    service.add_user(User("user2"))
    user2 = service.get_user(2)
    service.add_user(User("user3"))
    user3 = service.get_user(3)

    print(user1.name)
    print(user2.name)
    print(user3.name)