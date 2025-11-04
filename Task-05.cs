using System;

class DateDemo
{
    static void Main()
    {
        // 1. Birthdate
        DateTime birthDate = new DateTime(2000, 5, 15); // replace with your birthdate

        // 2. Current date
        DateTime currentDate = DateTime.Now;

        // 3. Approximate age (just subtract years)
        int age = currentDate.Year - birthDate.Year;

        // 4. Print birthdate, current date, and age
        Console.WriteLine("Birthdate: " + birthDate.ToShortDateString());
        Console.WriteLine("Current date: " + currentDate.ToShortDateString());
        Console.WriteLine("Your approximate age: " + age + " years");

        // 5. Add 10 days to birthdate
        DateTime birthPlus10Days = birthDate.AddDays(10);
        Console.WriteLine("Birthdate + 10 days: " + birthPlus10Days.ToShortDateString());
    }
}
