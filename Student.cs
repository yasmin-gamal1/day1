using StudentLibrary; 
namespace StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Student student = new Student(1, "Yasmin Gamal", 22, "Bioinformatics");

           
            student.PrintStudentDetails();

            if (student.IsAdult())
            {
                Console.WriteLine("The student is an adult.");
            }
            else
            {
                Console.WriteLine("The student is not an adult.");
            }

            Console.ReadLine(); 
        }
    }
}
