using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework_Functional_Programming
{
    static class ExtentionClass
    {
        public static List<Student> FindPoorStudents(this List<Student> students )
        {
            var poorStudents = students.Where(student => student.Marks.Count(p => p == 2) == 2).Select(p => p);
            return poorStudents.ToList();
        }
    }
}
