using EmployeeWageApp;

Console.Title = "Employee Wage App";
Console.WriteLine("-----------------Employee Wage Calculation App-----------------");
EmployeeWage employee = new EmployeeWage();
employee.GetAttendance();
employee.GetDailyWage();
Console.ReadKey();
