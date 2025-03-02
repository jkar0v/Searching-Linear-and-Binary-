namespace zad_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            University university = new University();
            university.AddStudent(new Student { Name = "John", Score = 4.5 });
            university.AddStudent(new Student { Name = "Alice", Score = 6.0 });
            university.AddStudent(new Student { Name = "Bob", Score = 3.2 });
            university.AddStudent(new Student { Name = "Eve", Score = 4.8 });
            university.AddStudent(new Student { Name = "Mallory", Score = 5.3 });
            university.AddStudent(new Student { Name = "Trent", Score = 3.4 });
            university.AddStudent(new Student { Name = "Carol", Score = 5.7 });
            university.AddStudent(new Student { Name = "Dave", Score = 5.7 });

            Console.WriteLine("What score are we looking for?");
            double score = double.Parse(Console.ReadLine());
            List<string> names = university.FindStudentByScore(score);
            if (names.Count == 0)
            {
                Console.WriteLine("Not found!");
                return;
            }
            else
                Console.WriteLine(string.Join(", ", names));
        }
    }
}
