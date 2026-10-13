public static class PersonExercise
{
    public static void Run()
    {
        const int personCount = 5;
        var persons = new List<Person>();

        for (int i = 0; i < personCount; i++)
        {
            Console.Write($"Enter person {i + 1}'s first name, last name, and age: ");
            string[] input = Console.ReadLine()!.Split();

            string firstName = input[0];
            string lastName = input[1];
            int age = int.Parse(input[2]);

            try
            {
                persons.Add(new Person(firstName, lastName, age));
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
                i--;
            }
        }

        var sortedPersons = persons
            .OrderBy(person => person.Age)
            .ThenBy(person => person.FirstName);

        foreach (var person in sortedPersons)
        {
            Console.WriteLine(person);
        }
    }
}


