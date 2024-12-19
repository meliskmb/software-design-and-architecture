using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp__2
{
    public class Database
    {
        private List<string> list;
        private bool check = false;

        public Database()
        {
            list = new List<string>();
        }

        public List<string> GetList(){return this.list;}

        public void AddLog(string log){
            if (check)
                list.Add(log);
        }

        public void OpenDatabase(){
            Console.WriteLine("The database connection is open.");
            check = true;
        }

        public void CloseDatabase(){
            Console.WriteLine("The database connection is closed.");
            check = false;
        }
    }
}