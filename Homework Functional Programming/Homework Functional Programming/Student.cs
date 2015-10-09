using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework_Functional_Programming
{
    class Student
    {
       
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public int Age { set; get; }
        public string FacultyNumber { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public IList<int> Marks{set; get;}
        public int GroupNumber { set; get; }

        public Student(string firstName, string lastName, int age, string facultyNumber,string phone ,string email , IList<int> marks,int groupNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FacultyNumber = facultyNumber;
            Phone = phone;
            Email = email;
            Marks = marks;
            GroupNumber = groupNumber;
        }

        public  void PrintStudent()
        {
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} ", FirstName, LastName, Age, FacultyNumber, Phone, Email,
                GroupNumber);
        }



    }
}
