using PrototypePattern;

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student();
        student1.Name = "Apurva";
        student1.Department = "Computer Engineering";
        student1.Age = 21;

        Console.WriteLine("Original Object:");
        student1.Display();

        Student student2 = (Student)student1.Clone();

        student2.Name = "Rahul";  // modifying clone

        Console.WriteLine("\nCloned Object (after modification):");
        student2.Display();

        Console.WriteLine("\nOriginal Object remains unchanged:");
        student1.Display();
    }
}
