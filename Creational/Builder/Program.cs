using BuilderPattern;

class Program
{
    static void Main(string[] args)
    {
        Student student = new StudentBuilder()
            .SetName("Apurva")
            .SetAge(21)
            .SetDepartment("Computer Engineering")
            .HasHostel(true)
            .HasScholarship(true)
            .Build();

        student.Display();
    }
}
