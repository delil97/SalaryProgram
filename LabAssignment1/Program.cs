using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment1
{
    class Program
    {             
        static void Main(string[] args)
        {
            List<Programers> progList = new List<Programers>();


            Programers p1 = new Programers("Anders", 30000, 1, "Java");
      
            Programers p2 = new Programers("Johan", 30000, 2, "C#");
       
            Programers p3 = new Programers("Sven", 30000, 3, "C++");

            Programers p4 = new Programers("Johanna", 30000, 4, "Python");

            List<Employee> empLista = new List<Employee>();
            SoftwareCompany s1 = new SoftwareCompany(empLista, "ComputerDc");
            s1.addEmployee(empLista, p1);
            s1.addEmployee(empLista, p2);
            s1.addEmployee(empLista, p3);
           s1.addEmployee(empLista, p4);


            List<Programers> mentorList = new List<Programers>();
            mentorList.Add(p1);
            mentorList.Add(p2);
            mentorList.Add(p3);
            mentorList.Add(p4);



            ProgramLeader pl1 = new ProgramLeader("Milad", 30000, 5, "Java", mentorList);
            pl1.mentorList.Add(p1);

            ProgramLeader pl2 = new ProgramLeader("Erik", 30000, 6, "C#", mentorList);
            pl2.mentorList.Add(p2);

            ProgramLeader pl3 = new ProgramLeader("Alan", 30000, 7, "C++", mentorList);
            pl3.mentorList.Add(p3);

            ProgramLeader pl4 = new ProgramLeader("Magnus", 30000, 8, "C++", mentorList);
            pl4.mentorList.Add(p4);

            List<ProgramLeader> k = new List<ProgramLeader>();
            k.Add(pl1);
            k.Add(pl2);
            k.Add(pl3);
            k.Add(pl4);

            Console.WriteLine("Programleaders:");

            foreach (var item in k)
            {
                Console.WriteLine("Name: " + item.name + ", Salary: " + item.salary + ", Salary Id: " + item.salaryId + ", Language: " + item.language );
            }






        }
    }
}
