namespace EmployeeWageApp;

/// <summary>
/// Interface for managing wage of multiple companies
/// </summary>
public interface ICompanyWage
{
    /// <summary>
    /// Adds the company.
    /// </summary>
    /// <param name="companyName">Name of the company.</param>
    void AddCompany(string companyName);

    /// <summary>
    /// Adds the company.
    /// </summary>
    /// <param name="companyName">Name of the company.</param>
    /// <param name="ratePerHour">The rate per hour.</param>
    /// <param name="maxWorkingDays">The maximum working days.</param>
    /// <param name="maxHoursPerMonth">The maximum hours per month.</param>
    void AddCompany(string companyName, int ratePerHour, int maxWorkingDays, int maxHoursPerMonth);

    /// <summary>
    /// Computes the wage.
    /// </summary>
    /// <param name="companyName">Name of the company.</param>
    void ComputeWage(string companyName);
}