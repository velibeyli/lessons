using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Branchs
            var programmingB = new Branch
            {
                Id = 101,
                Name = "Programming"
            };

            var designB = new Branch
            {
                Id = 102,
                Name = "Design"
            };

            var biologyB = new Branch
            {
                Id = 103,
                Name = "Biology"
            };

            List<Branch> branches = new List<Branch>()
            {
                programmingB,
                designB,
                biologyB
            };
            #endregion

            #region Teachers
            var samirT = new Teacher
            {
                Id = 201,
                Name = "Samir",
                Surname = "Cavadov",
                Gender = Gender.Male,
                DateOfBirth = new DateTime(1997, 7 , 22)
            };

            var elsenT = new Teacher
            {
                Id = 202,
                Name = "Elsen",
                Surname = "Babayev",
                Gender = Gender.Male,
                DateOfBirth = new DateTime(1985, 8,12)
            };

            var gunayT = new Teacher
            {
                Id = 203,
                Name = "Gunay",
                Surname = "Babayeva",
                Gender = Gender.Female,
                DateOfBirth = new DateTime(1980, 4, 14)
            };

            var gunelT = new Teacher
            {
                Id = 204,
                Name = "Gunel",
                Surname = "Hesenova",
                Gender = Gender.Female,
                DateOfBirth = new DateTime(1993, 11, 29)
            };

            List<Teacher> teachers = new List<Teacher>()
            {
                samirT,
                elsenT,
                gunayT,
                gunelT
            };
            #endregion

            #region Groups
            var programmingG = new Group
            {
                Id = 301,
                Name = "P30",
                Branch = programmingB,
                Teacher = samirT
            };

            var designG = new Group
            {
                Id = 302,
                Name = "D25",
                Branch = designB,
                Teacher = gunayT
            };

            var biologyG = new Group
            {
                Id = 302,
                Name = "B47",
                Branch = biologyB,
                Teacher = gunelT
            };

            List<Group> groups = new List<Group>()
            {
                programmingG,
                designG,
                biologyG
            };
            #endregion

            #region Students
            List<Student> students = new List<Student>()
            {
                new Student
                {
                    Id = 401,
                    Name = "Ruslan",
                    Surname = "Velibeyli",
                    Gender = Gender.Male,
                    Email = "ruslan@gmail.com",
                    Phone = 0555887878,
                    Point = 75.2d,
                    Group = programmingG,
                    DateOfBirth = new DateTime(1996, 1, 24)
                },                
                new Student
                {
                    Id = 406,
                    Name = "Natiq",
                    Surname = "Natiq",
                    Gender = Gender.Male,
                    Email = "natiq@gmail.com",
                    Phone = 0518888878,
                    Point = 98.2d,
                    Group = biologyG,
                    DateOfBirth = new DateTime(2005, 12, 20)
                },
                new Student
                {
                    Id = 402,
                    Name = "Cavid",
                    Surname = "Cavidov",
                    Gender = Gender.Male,
                    Email = "cavid@gmail.com",
                    Phone = 0552227878,
                    Point = 56.1d,
                    Group = programmingG,
                    DateOfBirth = new DateTime(2000, 6, 15)
                },
                new Student
                {
                    Id = 404,
                    Name = "Samil",
                    Surname = "Samilov",
                    Gender = Gender.Male,
                    Email = "samil@gmail.com",
                    Phone = 0993237878,
                    Point = 53.9d,
                    Group = designG,
                    DateOfBirth = new DateTime(2002, 10, 27)
                },
                 new Student
                {
                    Id = 403,
                    Name = "Teymur",
                    Surname = "Teymurov",
                    Gender = Gender.Male,
                    Email = "teymur@gmail.com",
                    Phone = 0513237878,
                    Point = 48.6d,
                    Group = designG,
                    DateOfBirth = new DateTime(1991, 3, 9)
                },
                new Student
                {
                    Id = 405,
                    Name = "Seymur",
                    Surname = "Seymur",
                    Gender = Gender.Male,
                    Email = "seymur@gmail.com",
                    Phone = 0517777778,
                    Point = 79.7d,
                    Group = biologyG,
                    DateOfBirth = new DateTime(1994, 2, 16)
                }                
            };
            #endregion



            //var matchesStudents = students.Where(s => s.Id == 401 || s.Id > 404).ToList();

            DateTime xDate = new DateTime(1995, 12, 5);
            //var matchesStudents = students.Where(s => s.DateOfBirth > xDate).ToList();

            //var matchesStudents = students.Where(s => s.Group.Teacher.Id == 201).ToList();
                       
            var ordering = students.OrderBy(x => x.Id);
            ordering = ordering.OrderBy(x => x.Name);

            var exceptStudents = students.Where(s => s.Name == "Ruslan" || s.Name == "Seymur");

            var exceptStudentsresult = students.Except(exceptStudents)
                .Select(s => s.Name);

            var anonymousTypeClass = students.Select(m => new
            {
                m.Name,
                m.Surname
            });

            Console.WriteLine(anonymousTypeClass.FirstOrDefault().Name)


            //Console.WriteLine("Student count: " + newList.Count);
            //Remove datas from list 
            //newList.RemoveAll(x => x.Group.Teacher.Id == 201);

            //Remove single data from list
            //Wrong method to remove single data from list
            //newList.Remove(newList.First(s => s.Id == 401));

            //Right method to remove single data from list
            //var removeStudent = students.FirstOrDefault(s => s.Group.Teacher.Id == 201);
            //newList.Remove(removeStudent);

            //Console.WriteLine("Student count: " + newList.Count);



            //foreach (var student in newList)
            //{
            //Console.WriteLine("Student info:");
            //Console.WriteLine("Id: " + student.Id);
            //Console.WriteLine("Name: " + student.Name);
            //Console.WriteLine("Surname: " + student.Surname);
            //Console.WriteLine("Phone: " + student.Phone);
            //Console.WriteLine("Point: " + student.Point);
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("Gender: " + student.Gender);
            //Console.WriteLine("Email: " + student.Email);
            //Console.WriteLine("BirthDate: " + student.DateOfBirth);
            //Console.WriteLine();
            //Console.WriteLine("Group info: ");
            //Console.WriteLine("Id: " + student.Group.Id);
            //Console.WriteLine("Name: " + student.Group.Name);
            //Console.WriteLine();
            //Console.WriteLine("Teacher info:");
            //Console.WriteLine("Id: " + student.Group.Teacher.Id);
            //Console.WriteLine("Name: " + student.Group.Teacher?.Name);
            //Console.WriteLine("Surname: " + student.Group.Teacher.Surname);
            //Console.WriteLine("BirthDate : " + student.Group.Teacher.DateOfBirth);
            //Console.WriteLine("Gender : " + student.Group.Teacher.Gender);
            //Console.WriteLine();
            //Console.WriteLine("Branch info:");
            //Console.WriteLine("Id: " + student.Group.Branch.Id);
            //Console.WriteLine("Name: " + student.Group.Branch.Name);
            //Console.WriteLine();

            //}

            List<string> names = new List<string>() {
                "alma",
                "qarpiz",
                "armud",
                "heyva",
                
            };

            List<string> names1 = new List<string>() {
                "nar",
                "uzum",
                "saftali",
                "nar",
                "feyxoa",
                "ezgil",
                "banan",
                "kivi"
            };

            List<string> exceptList = new List<string>() {
                "uzum",
                "saftali",         
            };

            var concatNames = names.Concat(names1).ToList();
            //concatNames.ForEach(m => Console.WriteLine(m));

            var except = concatNames.Except(exceptList).ToList();
            //foreach (var item in except)
            //{
            //    Console.WriteLine(item);
            //}
           

            var takeNames = names.Take(3);

            foreach (var item in takeNames)
                Console.WriteLine(item);

            Console.WriteLine("---------------------------");


            var skipNames = names.Skip(3);
            foreach (var item in skipNames)
                Console.WriteLine(item);




            var findIndexOfNar = names.FindIndex(n => n == "nar");
            //Console.WriteLine(findIndexOfNar);

            var findLastOfNar = names.FindLast(n => n == "nar");
            //Console.WriteLine(findLastOfNar);

            var findOfNar = names.Find(n => n == "nar");
            //Console.WriteLine(findOfNar);

            var findLastIndexOfNar = names.FindLastIndex(n => n == "nar");
            //Console.WriteLine(findLastIndexOfNar);

            var firstMember = names.First();
            var lastMember = names.Last();

            //Console.WriteLine(firstMember);
            //Console.WriteLine(lastMember);

            List<int> numbers = new List<int>()
            {
                15,
                20,
                150,
                350,
                565,
                9565
            };

            var minNumber = numbers.Min();
            var maxNumber = numbers.Max();
            var sumNumber = numbers.Sum();

            //Console.WriteLine(maxNumber);
            //Console.WriteLine(minNumber);
            //Console.WriteLine(sumNumber);
            Console.ReadLine();
        }
    }
}
