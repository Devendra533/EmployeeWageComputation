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
       private const int NUM_OF_WORKING_DAY = 20;
       private const int MAX_HOURS_IN_MONTH = 100;

        private int empHrs = 0;
        private int empWage = 0;
        private int totalEmpWage = 0;
       private int totalEmpHrs = 0;
        private int totalWorkDays = 0;

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
            switch (empCheck)
            {
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;

            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage: " + empWage);
            Console.ReadKey();
        }
 
        
        public void EmpMonthlyWage()
        { 
            
            for (int day = 0; day < NUM_OF_WORKING_DAY; day++)
            { 
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Emp Wage: " + empWage);
                Console.WriteLine("Total Emp Wage: " + totalEmpWage);
                Console.ReadKey ();
            }
        }
       
      
        public  void EmpMonthlyWageCondition()
        {
            
            while (totalEmpHrs <= MAX_HOURS_IN_MONTH && totalWorkDays < NUM_OF_WORKING_DAY)
            {
                totalWorkDays++; 
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days#: " + totalWorkDays + " Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * MAX_HOURS_IN_MONTH;
            Console.WriteLine("Total Emp Wage: " + totalEmpWage);
            Console.ReadKey();
        }



    }
}