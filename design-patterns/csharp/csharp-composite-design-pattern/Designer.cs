using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_composite_design_pattern
{
    public class Designer : IEmployee
    {
        private int id;
        private string name;

        public Designer(int id, string name){
            this.id = id;
            this.name = name;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Designer's name: {this.name} | id: {this.id}");
        }
    }
}