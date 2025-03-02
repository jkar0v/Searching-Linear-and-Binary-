using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace zad_5
{
    internal class University
    {
        List<Student> students;

        public University()
        {
            students = new List<Student>();
        }
        internal void AddStudent(Student student)
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
                    if (students[j].Score > students[j + 1].Score)
                        (students[j], students[j + 1]) = (students[j + 1], students[j]);
                }
            }
        }
        internal List<string> FindStudentByScore(double score)
        {
            List<string> result = new List<string>();
            int left = 0;
            int right = this.students.Count - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (students[mid].Score == score)
                {
                    result.Add(students[mid].Name);
                    
                    left = mid - 1;
                    while (left >= 0 && students[left].Score == score)
                    {
                        result.Add(students[left].Name);
                        left--;
                    }

                    right = mid + 1;
                    while (right < students.Count && students[right].Score == score)
                    {
                        result.Add(students[right].Name);
                        right++;
                    }
                    break;
                }
                else if (students[mid].Score < score)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return result;
        }
    }
}
