namespace BuilderPattern
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public bool Hostel { get; set; }
        public bool Scholarship { get; set; }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Hostel: {Hostel}");
            Console.WriteLine($"Scholarship: {Scholarship}");
        }
    }
}
