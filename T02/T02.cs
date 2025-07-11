int[] years = [2000, 1900, 2024, 2025];
foreach (var year in years)
{
    Console.WriteLine($"Is Leap Year for {year}: {IsLeapYear(year)}");
}

return;

bool IsLeapYear(int year)
{
    if (year % 100 == 0)
    {
        if (year % 400 == 0)
            return true;
        else
            return false;
    }
    else
    {
        if (year % 4 == 0)
            return true;
        else
            return false;
    }
}