using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_factory
{
    public class Mysql : IDatabase
    {
        public void SelectData(){
            Console.WriteLine("Data retrieval operation was successfully performed in Mysql.");
        }
        public void InsertData(){
            Console.WriteLine("Data insertion was successfully performed in Mysql.");
        }       
    }
}