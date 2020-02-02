using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment1
{
    public class Employee
    {

        public string name { get; set; }
        public double salary;
        public double salaryId { get; set; }

        public Employee(string name, double salary, double salaryId)
        {
            this.name = name;
            this.salary = salary;
            this.salaryId = salaryId;
        }

        public virtual void SalaryCalculator()
        {


        }

    }

 

}


