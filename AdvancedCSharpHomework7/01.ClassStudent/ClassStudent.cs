using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ClassStudent
{
    class ClassStudent
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            List<int> marks1 = new List<int>();
            marks1.Add(4);
            marks1.Add(2);
            marks1.Add(3);
            marks1.Add(4);
            marks1.Add(6);
            marks1.Add(3);
            marks1.Add(2);
            marks1.Add(6);
            List<int> marks2 = new List<int>();
            marks2.Add(6);
            marks2.Add(5);
            marks2.Add(5);
            marks2.Add(6);
            marks2.Add(6);
            marks2.Add(6);
            marks2.Add(5);
            marks2.Add(6);
            List<int> marks3 = new List<int>();
            marks3.Add(3);
            marks3.Add(2);
            marks3.Add(3);
            marks3.Add(4);
            marks3.Add(2);
            marks3.Add(2);
            marks3.Add(2);
            marks3.Add(3);
            List<int> marks4 = new List<int>();
            marks4.Add(4);
            marks4.Add(4);
            marks4.Add(3);
            marks4.Add(4);
            marks4.Add(6);
            marks4.Add(5);
            marks4.Add(4);
            marks4.Add(4);
            students.Add(new Student("Angel", "Angelov", 28, "845612", "02-87-87-87", "angle@gmail.com", marks4, 1));
            students.Add(new Student("Todor", "Todorov", 29, "535411", "+3592-88-88-88", "todor@gmail.com", marks2, 2, "Sinovete na Onufri"));
            students.Add(new Student("Yanko", "Traversa", 27, "724303", "0877-99-97-97", "yanko@yahoo.com", marks1, 3));
            students.Add(new Student("Pencho", "Penev", 34, "556714", "0987-00-87-00", "pencho@abv.bg", marks3, 2, "Torliu Giuvech"));
            students.Add(new Student("Mitko", "Genchev", 40, "787815", "0997-99-87-99", "milcho@gmail.com", marks4, 1));
            students.Add(new Student("Stanush", "Stanushev", 20, "234514", "0907-88-89-88", "stanush@hotmail.com", marks2, 3, "Sinovete na Onufri"));
            students.Add(new Student("Zdravko", "Zdravkov", 19, "465513", "0886-55-66-77", "zdravko@abv.bg", marks3, 1));
            students.Add(new Student("Joro", "Jorov", 26, "345712", "0899-99-99-99", "joro@yahoo.com", marks1, 1));
            students.Add(new Student("Kincho", "Kinev", 31, "455614", "0888-88-88-88", "kincho@gmail.com", marks1, 2, "Torliu Giuvech"));
            students.Add(new Student("Onufri", "Onufriev", 27, "547614", "0777-77-77-77", "onufri@gmail.com", marks2, 2, "Sinovete na Onufri"));
            students.Add(new Student("Mitko", "Mitev", 33, "877613", "0997-12-34-56", "mitko@gmail.com", marks3, 2));
            students.Add(new Student("Shushumush", "Shushumushev", 24, "778712", "0987-56-78-45", "shushumush@gmail.com", marks4, 3, "Torliu Giuvech"));

            //var studentsByGroup =
            //    from stud in students
            //    orderby stud.FirstName
            //    select stud;
            //foreach (var stud in studentsByGroup)
            //{
            //    Console.WriteLine(stud);
            //}

            //var firstBeforeLastStudents =
            //    from stud in students
            //    where (stud.FirstName.CompareTo(stud.LastName) < 0)
            //    select stud;
            //foreach (var stud in firstBeforeLastStudents)
            //{
            //    Console.WriteLine(stud);
            //}

            //var ageBetweenStudents =
            //    from stud in students
            //    where stud.Age <= 24 && stud.Age >= 18
            //    select new {stud.FirstName, stud.LastName, stud.Age};
            //foreach (var stud in ageBetweenStudents)
            //{
            //    Console.WriteLine("{0} {1} - {2}", stud.FirstName, stud.LastName, stud.Age);
            //}

            //var orderedStudents = students
            //    .OrderBy(s => s.FirstName)
            //    .ThenByDescending(s => s.LastName);
            //foreach (var stud in orderedStudents)
            //{
            //    Console.WriteLine(stud);
            //}
            //var orderedAgainStudents =
            //    from stud in students
            //    orderby stud.FirstName, stud.LastName descending  
            //    select stud;
            //foreach (var stud in orderedAgainStudents)
            //{
            //    Console.WriteLine(stud);
            //}

            //var domainStudents =
            //    from stud in students
            //    where stud.Email.Contains("@abv.bg")
            //    select stud;
            //foreach (var stud in domainStudents)
            //{
            //    Console.WriteLine(stud + " - " + stud.Email);
            //}

            //var sofiaPhoneStudents =
            //    from stud in students
            //    where stud.Phone.StartsWith("02") || stud.Phone.StartsWith("+3592") || stud.Phone.StartsWith("+359 2")
            //    select stud;
            //foreach (var stud in sofiaPhoneStudents)
            //{
            //    Console.WriteLine(stud + " - " + stud.Phone);
            //}

            //var excellentStudents =
            //    from stud in students
            //    where stud.Marks.Contains(6)
            //    select new {FullName = stud.FirstName + " " + stud.LastName, Marks = stud.Marks};
            //foreach (var stud in excellentStudents)
            //{
            //    Console.WriteLine(stud.FullName + " - " + string.Join(", ", stud.Marks));
            //}

            //var poorStudents = 
            //    from stud in students
            //    where stud.Marks.FindAll(g => g == 2).Count == 2
            //    select new {FullName = stud.FirstName + " " + stud.LastName, Marks = stud.Marks};
            //foreach (var stud in poorStudents)
            //{
            //    Console.WriteLine(stud.FullName + " " + string.Join(", ", stud.Marks));
            //}

            //var lastYearStudents =
            //    from stud in students
            //    where stud.FacultyNumber[4] == '1' && stud.FacultyNumber[5] == '4'
            //    select stud;
            //foreach (var stud in lastYearStudents)
            //{
            //    Console.WriteLine(stud + " - " + stud.FacultyNumber + " - " + string.Join(", ", stud.Marks));
            //}

            //var groupStudents =
            //    from stud in students
            //    group stud by stud.GroupName;
            //foreach (var studGroup in groupStudents)
            //{
            //    Console.WriteLine("\n" + studGroup.Key + "\n\t" + string.Join("\n\t", studGroup));
            //}


        }
    }
}
