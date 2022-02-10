using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeOperation
    {
       private const int IS_FULL_TIME = 1;
       private const int IS_PART_TIME = 2;
       private const  int EMP_RATE_PER_HOUR = 20;

       private int empHrs = 0;
        private int empWage = 0;

        Random random = new Random();
        
        public void GetAttendance()
        {
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
        public void EmpWage()
        {
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
                empHrs = 8;
            else
             empHrs = 0;
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage: " + empWage);
            Console.ReadKey();
        }
        public void EmpPartTimeWage()
        {
           int empCheck = random.Next(0, 3);
            if (empCheck == IS_FULL_TIME)
                empHrs = 4;
            else if (empCheck == IS_PART_TIME)
                empHrs = 8;
            else
            empHrs = 0;
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage: " + empWage);
            Console.ReadKey();
        }
    }
}