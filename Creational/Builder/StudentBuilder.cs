namespace BuilderPattern
{
    public class StudentBuilder
    {
        private Student _student = new Student();

        public StudentBuilder SetName(string name)
        {
            _student.Name = name;
            return this;
        }

        public StudentBuilder SetAge(int age)
        {
            _student.Age = age;
            return this;
        }

        public StudentBuilder SetDepartment(string department)
        {
            _student.Department = department;
            return this;
        }

        public StudentBuilder HasHostel(bool value)
        {
            _student.Hostel = value;
            return this;
        }

        public StudentBuilder HasScholarship(bool value)
        {
            _student.Scholarship = value;
            return this;
        }

        public Student Build()
        {
            return _student;
        }
    }
}
