using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace LINQAssignment
{
    public class Employee
    {
        private int id;
        private string name;
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
    class EmployeeData
    {
        public void getData()
        {
            //Data sourse collection
            List<Employee> list = new List<Employee>();
            Employee emp = new Employee();
            emp.Id=10;
            emp.Name = "Yogesh";
            Employee emp1 = new Employee();
            emp1.Id = 11;
            emp1.Name = "Akash";
            list.Add(emp);
            list.Add(emp1);
            foreach(var emp2 in list)
            {
                Console.WriteLine(emp2.Name+" "+emp2.Id);
            }
            //step 2 query creation
            var query = from lst in list where lst.Id == 10 && lst.Name == "Yogesh" select lst.Name;
            //Step 3 query execution
         
            foreach(string Name in query)
            {
                Console.WriteLine(Name);
            }
            //Group By
            var groupedResult = from s in list
                                group s by s.Id;

            //iterate each group        
            foreach (var group in groupedResult)
            {
                Console.WriteLine("Employee ID: {0}", group.Key); //Each group has a key 

                foreach (Employee s in group) // Each group has inner collection
                    Console.WriteLine("Employee Name: {0}", s.Name);
            }
           //order by
            var Result = from s in list orderby s.Id descending select s;
            foreach (var s in Result)
            {
                Console.WriteLine(s.Name);
            }
        }

       
    }
    class EmployeeMain
    {
        static void Main(string[] args)
        {
            EmployeeData obj = new EmployeeData();
            obj.getData();
           // Console.ReadKey();
        }
    }
}
