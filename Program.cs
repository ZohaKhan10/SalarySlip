using System;

namespace salaryslip
{
    class Program
    {
        public class SalarySlip
        {
            private string Designation;
            private int grossSalary;

            public string getDesignation()
            {
                return Designation;
            }

            public void setDesignation()
            {
                Console.WriteLine("Enter your designation");
                Designation = Console.ReadLine();
            }


            public void Salary()
            {
                if(Designation=="engineer")
                {
                    Employee E = new Employee();
                    grossSalary = E.baseSalary + E.Allowance();
                    Console.WriteLine("The gross salary is:"+ grossSalary);
                    
                }
                else if (Designation == "manager")
                {
                    Manager M = new Manager();
                    grossSalary = M.baseSalary + M.Allowance();
                    Console.WriteLine("The gross salary is:" + grossSalary);

                }
                else if (Designation == "Analyst")
                {
                    Analyst A = new Analyst();
                    grossSalary = A.baseSalary + A.Allowance();
                    Console.WriteLine("The gross salary is:" + grossSalary);

                }

                else
                {
                    Console.WriteLine("The designation entered is incorrect");
                }


            }
        }

        class Employee
        {
            public int baseSalary = 1500;
            public int fuel;
            public int medical;
            public virtual int Allowance()
            {
                 fuel = 100;
                 medical = 500;

                return (fuel + medical);
            }

        }


        class Manager : Employee
        {
            public override int Allowance()
            {
                 fuel = 250;
                 medical = 1000;

                return (fuel + medical);
            }


        }


        class Analyst : Employee
        {
            public override int Allowance()
            {
                int fuel = 150;
                int medical = 800;

                return (fuel + medical);
            }
        }



        static void Main(string[] args)
        {

            SalarySlip S = new SalarySlip();
         
            S.setDesignation();
          //  Console.WriteLine(S.getDesignation());
            S.Salary();
            Console.ReadLine();

        }
    }
}
