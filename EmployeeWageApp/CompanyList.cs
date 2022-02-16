namespace EmployeeWageApp;

/// <summary>
/// This class handles collection of multiple companies
/// </summary>
/// <seealso cref="EmployeeWageApp.CompanyWageInterface" />
internal class CompanyList : CompanyWageInterface
{
    /// <summary>
    /// The companies are stored in a Dictionary.
    /// Stores company name as key and coresponding wages as value
    /// </summary>
    private readonly Dictionary<string, EmployeeWage> companies;

    /// <summary>
    /// Initializes a new instance of the <see cref="CompanyList"/> class.
    /// </summary>
    public CompanyList()
    {
        companies = new();
    }

    /// <summary>
    /// Adds a company with default wage parameter values.
    /// </summary>//
    /// <param name="companyName">Name of the company.</param>
    public void AddCompany(string companyName)
    {
        companies.Add(companyName, new EmployeeWage(companyName));
        ComputeWage(companyName);
    }

    /// <summary>
    /// Adds a company.
    /// </summary>
    /// <param name="companyName">Name of the company.</param>
    /// <param name="ratePerHour">The rate per hour.</param>
    /// <param name="maxWorkingDays">The maximum working days.</param>
    /// <param name="maxHoursPerMonth">The maximum hours per month.</param>
    public void AddCompany(string companyName, int ratePerHour, int maxWorkingDays, int maxHoursPerMonth)
    {
        companies.Add(companyName, new EmployeeWage(companyName, ratePerHour, maxWorkingDays, maxHoursPerMonth));
        ComputeWage(companyName);
    }

    public void ComputeWage(string companyName)
    {
        companies[companyName].MeetWageCondition();
    }

    /// <summary>
    /// Displays the list of companies and their wage details.
    /// </summary>
    public void Display()
    {
        foreach (var company in companies.Values)
            Console.WriteLine("\nCompany: " + company.Company + "\n" + company.ToString() + "\n");
    }
}