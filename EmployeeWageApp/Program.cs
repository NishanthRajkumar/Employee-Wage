using EmployeeWageApp;

Console.Title = "Employee Wage App";
Console.WriteLine("-----------------Employee Wage Calculation App-----------------");

// Creating an object of CompanyList
CompanyList companyList = new();

// Adding company with default values for wage, number of working days and working hours per month
companyList.AddCompany("Reliance");
companyList.AddCompany("Tata");

// Adding company with parameters for wage, number of working days and working hours per month
companyList.AddCompany("Facebook", 50, 22, 120);

// Display all companies
companyList.Display();

Console.ReadKey();