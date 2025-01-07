using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_composite_design_pattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HumanResources hrDesigner = new HumanResources("hr designer");
            IEmployee designer1 = new Designer(1, "designer1");
            IEmployee designer2 = new Designer(2, "designer2");
            hrDesigner.AddEmployee(designer1);
            hrDesigner.AddEmployee(designer2);

            HumanResources hrDeveloper = new HumanResources("hr developer");
            IEmployee developer1 = new Developer(3, "developer1");
            IEmployee developer2 = new Developer(4, "developer2");
            hrDeveloper.AddEmployee(developer1);
            hrDeveloper.AddEmployee(developer2);

            IEmployee manager = new Manager(5, "manager");

            HumanResources humanResources = new HumanResources("hr main");
            humanResources.AddEmployee(hrDeveloper);
            humanResources.AddEmployee(hrDesigner);
            humanResources.AddEmployee(manager);

            humanResources.ShowInfo();
        }
    }
}
