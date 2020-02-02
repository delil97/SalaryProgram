using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment1
{
   public class ProgramLeader : Programers
    {
        public List<Programers> mentorList = new List<Programers>();


        public ProgramLeader(string name, double salary, double salaryId, string language, List<Programers> mentorList)
            : base(name, salary, salaryId, language)
        {
           

        }

        public override double mentorCalculater()
        {
            double bonus = mentorList.Count * 0.05 * 30000;
            
             double mentorSalary = bonus + 30000;


            return mentorSalary;
        }

      
    }
}
