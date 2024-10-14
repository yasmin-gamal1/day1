namespace StudentLibrary
{
    public class Student
    {
       
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Major { get; set; }

        public Student(int id, string name, int age, string major)
        {
            ID = id;
            Name = name;
            Age = age;
            Major = major;
        }

       
        public void PrintStudentDetails()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Major: {Major}");
        }

        
        public bool IsAdult()
        {
            return Age >= 18;
        }
    }
}
