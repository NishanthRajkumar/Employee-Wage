namespace EmployeeWageApp;

/// <summary>
/// Interface for managing wage of multiple companies
/// </summary>
internal interface CompanyWageInterface
{
    void AddCompany(string companyName);
    void AddCompany(string companyName, int ratePerHour, int maxWorkingDays, int maxHoursPerMonth);
    void ComputeWage(string companyName);
}