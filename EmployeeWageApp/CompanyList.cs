namespace EmployeeWageApp;

/// <summary>
/// This class handles collection of multiple companies
/// </summary>
/// <seealso cref="EmployeeWageApp.ICompanyWage" />
internal class CompanyList : ICompanyWage
{
    /// <summary>
    /// The companies are stored in a Dictionary.
    /// <para>Stores company name as key and coresponding wages as value.</para>
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
    /// <para>Default parameter:
    /// <list type="bullet">Rate per hour = 20</list>
    /// <list type="bullet">Working days per month = 20</list>
    /// <list type="bullet">Hours per month = 100</list>
    /// </para>
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

    /// <summary>
    /// Computes the wage for a company.
    /// </summary>
    /// <param name="companyName">Name of the company.</param>
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

    /// <summary>
    /// Gets the total wage for a company.
    /// </summary>
    public void GetTotalWage()
    {
        Console.Write("Enter name of Company: ");
        string companyName = Console.ReadLine();
        if (companies.ContainsKey(companyName))
            Console.WriteLine("Total Wage: " + companies[(companyName)].TotalWage);
        else
            Console.WriteLine("Company does not exist!");
    }
}