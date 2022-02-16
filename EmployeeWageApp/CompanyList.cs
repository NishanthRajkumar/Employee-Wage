namespace EmployeeWageApp;

// This class handles collection of multiple companies
internal class CompanyList
{
    // Declaring class attribute of type Dictionary
    private readonly Dictionary<string, EmployeeWage> companies;

    // Initialise the dictionary
    public CompanyList()
    {
        companies = new();
    }

    // Add company name and uses default parameters for EmployeeWage and meets wage condition
    public void AddCompany(string companyName)
    {
        companies.Add(companyName, new EmployeeWage());
        companies[companyName].MeetWageCondition();
    }

    // Add company with additional parameters  and meets wage condition
    public void AddCompany(string companyName, int ratePerHour, int maxWorkingDays, int maxHoursPerMonth)
    {
        companies.Add(companyName, new EmployeeWage(ratePerHour, maxWorkingDays, maxHoursPerMonth));
        companies[companyName].MeetWageCondition();
    }

    // Display all companies
    public void Display()
    {
        foreach (var company in companies)
            Console.WriteLine("\nCompany: " + company.Key + "\n\tWage details:\n\t" + company.Value.ToString());
    }
}