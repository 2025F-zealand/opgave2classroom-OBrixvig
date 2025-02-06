// See https://aka.ms/new-console-template for more information
using ClassRoomNet60;

Console.WriteLine("Hello, World!");

ClassRoom classRoom1 = new ClassRoom();

classRoom1.ClassName = "3Q";
classRoom1.SemesterStart = new DateTime (2019,08,26);

Student oliver = new Student("Oliver", 12, 04);
Student kevin = new Student("Kevin", 12, 02); 

classRoom1.StudentList.Add(oliver);
classRoom1.StudentList.Add(kevin);

Console.WriteLine(classRoom1.ClassName +  "\n" + classRoom1.SemesterStart + "\n");
classRoom1.StudentList.ForEach(student => Console.WriteLine(student));
