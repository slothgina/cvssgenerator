using System;

namespace cvssgenerator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("--- CVSS v4.0 Vector String Generator ---");
            Console.WriteLine("Help: [N]etwork, [A]djacent, [L]ocal, [P]hysical");

            try
            {
                Console.WriteLine("Enter Attack Vector (AV) Code: ");
                string? input = Console.ReadLine();
                if (input == null)
                {
                    Console.WriteLine("Invalid input. Please enter a valid code.");
                    throw new FormatException("The code entered is not a valid CVSS v4.0 metric.");
                }
                char avCode = char.Parse(input);
            

            if (avCode != 'N' && avCode != 'A' && avCode != 'L' && avCode != 'P')
            {
                Console.WriteLine("Invalid AV code. Please enter a valid code.");
                throw new FormatException("The code entered is not a valid CVSS v4.0 metric.");

            }

            string vector = $"CVSS:4.0/AV:{avCode}/AC:L/AT:N/PR:N/UI:N/VC:H?VA:H/SC:N?SI:N/SA:N";

            Console.WriteLine("\n[SUCCESS] Valid CVSS v4.0 Vector Created:");
            Console.WriteLine(vector);
}
catch (FormatException ex)
{
            Console.WriteLine($"\n[INPUT ERROR]: {ex.Message}");
            Console.WriteLine("Security Note: All inputs must follow the CVSS v4.0 standard.");
}
catch (Exception ex)
{
            Console.WriteLine($"\n[UNEXPECTED ERROR]: {ex.Message}");
}

        Console.WriteLine($"\nApplication complete. Press any key to exit.");
        Console.ReadKey();
        }
    }
}           
