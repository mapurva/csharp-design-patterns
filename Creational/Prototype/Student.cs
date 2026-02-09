namespace PrototypePattern
{
    public class Student : Prototype
    {
        public string Name;
        public string Department;
        public int Age;

        public override Prototype Clone()
        {
            // Shallow Copy
            return (Prototype)this.MemberwiseClone();
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Age: {Age}");
        }
    }
}
