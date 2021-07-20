using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class EmpArrayList
    {
        public static void Main(string[] args)
        {
            List<Employee> lst = new List<Employee>();
            lst.Add(new Employee() { EmpId = 101, EmpName = "Patil", Address = "Pune" });
            lst.Add(new Employee() { EmpId = 102, EmpName = "Soanwane", Address = "Nagar" });
            lst.Add(new Employee() { EmpId = 103, EmpName = "Mhaske", Address = "Nasik" });
            lst.Add(new Employee() { EmpId = 104, EmpName = "Shinde", Address = "Satara" });

            //foreach (Employee v in lst)
            //{
            //    Console.WriteLine(v);
            //}
            var query = from emp in lst select emp.EmpId;
            Console.WriteLine(query);            
        }
    }
}
