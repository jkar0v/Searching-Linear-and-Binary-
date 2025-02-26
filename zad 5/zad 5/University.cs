using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_5
{
    internal class University
    {
        List<Student> students;

        public University()
        {
            students = new List<Student>();
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
            SortStudents();
        }
        private void SortStudents()
        {
            for (int i = 0; i < students.Count - 1; i++)
            {
                for (int j = 0; j < students.Count - i - 1; j++)
                {
                    if (students[j].Name.CompareTo(students[j + 1].Name) == -1)
                        (students[j], students[j + 1]) = (students[j + 1], students[j]);
                }
            }
        }
    }
}
