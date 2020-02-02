using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment1
{
    public class Programers: Employee
    {
      //  List<Programers> mentorList;

        public string language { get; set; }

           public Programers(string name, double salary, double salaryId, string language)
                :base(name, salary, salaryId)
            {   
                this.language = language;
            }
        public double SalaryCalculator(string language)
        {
            try
            {
                if (language == "java".ToUpper().ToLower())
                {
                    salary += salary * 1.1;
                }

            }

            catch
            {

            }
            return salary;


        }

        public void addProgrammers(List<Programers> progList, Programers p)
        {
            progList.Add(p);
        }

        public override void SalaryCalculator()
        {


        }

        public virtual double mentorCalculater()
        {

            return salaryId;
        }
    }
    
}



