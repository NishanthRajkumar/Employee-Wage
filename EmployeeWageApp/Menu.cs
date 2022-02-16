namespace EmployeeWageApp;

/// <summary>
/// Menu option for the Company wage management
/// </summary>
internal class Menu
{
    /// <summary>
    /// Lists the menu options.
    /// </summary>
    public static void List()
    {
        int option;
        CompanyList companyList = new();
        do
        {
            Console.Clear();
            Console.WriteLine("-------------Company Wage Management-------------");
            Console.WriteLine("Choose from following:\n");
            Console.WriteLine("1. Add new company name (Default wage details)");
            Console.WriteLine("2. Add new company name (Custom wage details)");
            Console.WriteLine("3. Get total wage of a company");
            Console.WriteLine("4. Display wage details of all companies");
            Console.WriteLine("5. Exit");
            option = GetPositiveInt("Enter option(1-5): ");
            Console.Clear();
            switch (option)
            {
                case 1:
                    companyList.AddCompany(GetCompanyName());
                    break;
                case 2:
                    string companyName = GetCompanyName();
                    int ratePerHour = GetPositiveInt("Rate Per Hour: ");
                    int maxWorkingDays = GetPositiveInt("Max Woring Days: ");
                    int maxHoursPerMonth = GetPositiveInt("Max Hours per month: ");
                    companyList.AddCompany(companyName, ratePerHour, maxWorkingDays, maxHoursPerMonth);
                    break;
                case 3:
                    companyList.GetTotalWage();
                    break;
                case 4:
                    companyList.Display();
                    break;
                case 5:
                    Console.WriteLine("Exiting!!!");
                    break;
                default:
                    Console.WriteLine("Invalid Option!!!");
                    break;
            }
            Console.WriteLine("Press any key to Continue...");
            Console.ReadKey();
        } while (option != 5);
    }

    /// <summary>
    /// Gets a positive integer.
    /// </summary>
    /// <param name="message">The message for user input.</param>
    /// <returns>Positive number</returns>
    private static int GetPositiveInt(string message)
    {
        int number;
        bool IS_INT;
        do
        {
            do
            {
                Console.Write(message);
                IS_INT = Int32.TryParse(Console.ReadLine(), out number);
            } while (IS_INT is false);
        } while (number < 0);
        return number;
    }

    /// <summary>
    /// Gets the name of the company.
    /// </summary>
    /// <returns>A valid name as string</returns>
    private static string GetCompanyName()
    {
        string input;
        do
        {
            Console.Write("Enter Company Name: ");
            input = Console.ReadLine();
        } while (String.IsNullOrEmpty(input));
        return input;
    }
}