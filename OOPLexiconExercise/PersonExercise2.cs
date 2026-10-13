public static class PersonExercise2
{
    public static void Run()
    {
        const int personCount = 5;
        var persons = new List<Person>();

        for (int i = 0; i < personCount; i++)
        {
            Console.Write($"Enter person {i + 1}'s first name, last name, age, and salary: ");
            string[] input = Console.ReadLine()!
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string firstName = input[0];
            string lastName = input[1];
            int age = int.Parse(input[2]);
            decimal salary = decimal.Parse(input[3]);

            try
            {
                persons.Add(new Person(firstName, lastName, age, salary));
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
                i--;
            }
        }

        Console.Write("Enter salary increase percentage: ");
        decimal percentage = decimal.Parse(Console.ReadLine()!);

        foreach (var person in persons)
        {
            person.IncreaseSalary(percentage);
            Console.WriteLine($"{person} Salary: {person.Salary:F2}");
        }
    }
}

