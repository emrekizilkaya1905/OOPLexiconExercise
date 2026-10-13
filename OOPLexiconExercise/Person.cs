public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private decimal salary;

    public string FirstName => firstName;
    public int Age => age;
    public decimal Salary => salary;

    public Person(string firstName, string lastName, int age)
        : this(firstName, lastName, age, 460m)
    {
    }

    public Person(string firstName, string lastName, int age, decimal salary)
    {
        if (string.IsNullOrWhiteSpace(firstName) || firstName.Length < 3)
        {
            throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
        }

        if (string.IsNullOrWhiteSpace(lastName) || lastName.Length < 3)
        {
            throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
        }

        if (age <= 0)
        {
            throw new ArgumentException("Age cannot be zero or a negative integer!");
        }

        if (salary < 460m)
        {
            throw new ArgumentException("Salary cannot be less than 460 dollar!");
        }

        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.salary = salary;
    }

    public void IncreaseSalary(decimal percentage)
    {
        if (age < 30)
        {
            percentage /= 2;
        }

        salary += salary * percentage / 100;
    }

    public override string ToString()
    {
        return $"{firstName} {lastName} is {age} years old.";
    }
}

