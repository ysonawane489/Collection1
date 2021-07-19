using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Employee
    {
        private int empId;
        private string empName;
        private string address;

        public int EmpId { get => empId; set => empId = value; }
        public string EmpName { get => empName; set => empName = value; }
        public string Address { get => address; set => address = value; }
    }
}
