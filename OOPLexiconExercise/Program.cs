while (true)
{
    Console.WriteLine("1. Sort persons");
    Console.WriteLine("2. Increase salaries");
    Console.Write("Choose an exercise (any other input exits): ");

    string? choice = Console.ReadLine();

    if (choice == "1")
    {
        PersonExercise.Run();
    }
    else if (choice == "2")
    {
        PersonExercise2.Run();
    }
    else
    {
        break;
    }

    Console.WriteLine();
}
