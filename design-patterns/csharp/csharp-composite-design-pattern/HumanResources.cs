using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_composite_design_pattern
{
    public class HumanResources : IEmployee
    {
        private List<IEmployee> employeeList;
        private string test;

        public HumanResources(string test){
            this.test = test;
            employeeList = new List<IEmployee>();
        }

        public void AddEmployee(IEmployee employee)
        {
            employeeList.Add(employee);
        }

        public void RemoveEmployee(IEmployee employee)
        {
            employeeList.Remove(employee);
        }

        public void ShowInfo()
        {
            Console.WriteLine(test);
            foreach (var employee in employeeList)
            {
                employee.ShowInfo();
            }
        }
    }
}