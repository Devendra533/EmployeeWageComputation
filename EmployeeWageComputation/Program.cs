// See https://aka.ms/new-console-template for more information
using EmployeeWageComputation;


Console.WriteLine("Employee WAge Computation");
EmployeeOperation emp = new EmployeeOperation();
emp.GetAttendance();
emp.EmpWage();
emp.EmpPartTimeWage();
emp.EmpMonthlyWage();
emp.EmpMonthlyWageCondition();
Console.ReadKey();
