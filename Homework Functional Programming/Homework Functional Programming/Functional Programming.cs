using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Homework_Functional_Programming
{
    class FunctionalProggramming
    {
        static void Main()
        {
            #region Problem 1
            List<Student> students = new List<Student>
            {
                new Student("Georgi","Nqkakav",69,"05601411","0898888888","email@email.com",new List<int>{6,6,6},123),
                new Student("Petko", "Petkov",18,"3","07113","petkov@abv.bg",new List<int> {5, 2, 5, 6},2),
		    	new Student("Goshko", "Goskov",24,"4","+359245","goshov@gmail.com",new List<int> {5, 2, 2, 5},2),
		    	new Student("Mariika", "Marieva",20,"5","+359 2","niama@ght.gh",new List<int> {6, 2, 6, 4},1),
		    	new Student("Rositza", "Ivanova",21,"6","112345","pakmail@abv.bg",new List<int> {4, 2, 6, 3},2),
		    	new Student("Ivan", "Petkov",36,"7","024354","zashto@hotmail.com",new List<int> {6, 2, 6, 6},3),
                new Student("Ivailo", "Petkov",36,"754414","024354","zashtsdfo@hotmail.com",new List<int> {2, 2, 2, 6},3)
            };
            #endregion
            #region Problem 2
            //var groupStudents = students.Where(p => p.GroupNumber == 2).OrderBy(p => p.FirstName);
            //foreach (var student in groupStudents)
            //{
            //    student.PrintStudent();
            //}
            #endregion

            #region Problem 3

            //var studentsByName = students.Where((p) => p.FirstName.CompareTo(p.LastName) == 1);
            //foreach (var student in studentsByName)
            //{
            //    student.PrintStudent();
            //}

            #endregion

            #region Problem 4

            //var youngStudents =
            //    students.Where(p => p.Age >= 18 && p.Age <= 24).Select( student => new {student.FirstName, student.LastName, student.Age});
        
            //foreach (var student in youngStudents)
            //{
            //    Console.WriteLine("{0} {1} {2}",student.FirstName,student.LastName,student.Age);
            //}

            #endregion

            #region Problem 5

            //var sortStudents = students.OrderByDescending(student => student.FirstName).ThenByDescending(student => student.LastName);
            //var sortStudentsQuery = from student in students
            //    orderby student.FirstName descending, student.LastName
            //    select student;
            //foreach (var student in sortStudents)
            //{
            //    student.PrintStudent();
            //}
            //Console.WriteLine();
            //foreach (var student in sortStudentsQuery)
            //{
            //    student.PrintStudent();
            //}



            #endregion

            #region Problem 6

            //var studentsAbv = students.Where(student => Regex.IsMatch(student.Email, @"@abv.bg"));
            //foreach (var student in studentsAbv)
            //{
            //    student.PrintStudent();
            //}

            #endregion

            #region Problem 7

            //var studentsPhones = students.Where(student =>Regex.IsMatch(student.Phone,@"^02|359 2|3592"));

            //foreach (var student in studentsPhones)
            //{
            //    student.PrintStudent();
            //}
            #endregion

            #region Problem 8

            //var excellentStudents =
            //    students.Where(student => student.Marks.IndexOf(6) >= 0)
            //        .Select(student => new { student.FirstName, student.LastName, student.Marks });
            //foreach (var student in excellentStudents)
            //{
            //    Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, String.Join(", ", student.Marks));
            //}

            #endregion

            #region Problem 9

            //var weakStudents = students.FindPoorStudents();
            //foreach (var student in weakStudents)
            //{
            //    student.PrintStudent();
            //}
            #endregion

            #region Problem 10

            //var studentFreshmans =
            //    students.Where(student => student.FacultyNumber.Count()>=6 && (student.FacultyNumber[4] == '1' && student.FacultyNumber[5] == '4'))
            //        .Select(p => p);
            //foreach (var student in studentFreshmans)
            //{
            //    student.PrintStudent();
            //}

            #endregion
        }
    }
}
