public class Student
{
    public string Name { get; }
    public int Age { get; }
    private readonly string _city;

    public Student(string name, int age, string city)
    {
        Name = name;
        Age = age;
        _city = city;
    }

    public string GetCity()
    {
        return _city;
    }
}

public class StudentMain
{
    public static void Main()
    {
        Student student = new Student("John", 17, "London");

        Console.WriteLine(student.Name);
        Console.WriteLine(student.Age);
        Console.WriteLine(student.GetCity());
        Console.ReadLine();
    }
}