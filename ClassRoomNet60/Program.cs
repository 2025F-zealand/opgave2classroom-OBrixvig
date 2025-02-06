// See https://aka.ms/new-console-template for more information

using ClassRoomNet60;

try
{
    Console.WriteLine("Hello, World!");

    ClassRoom classRoom1 = new ClassRoom();

    classRoom1.ClassName = "3Q";
    classRoom1.SemesterStart = new DateTime(2019, 08, 26);

    Student oliver = new Student("Oliver", 12, 4);
    Student kevin = new Student("Kevin", 12, 2);

    Student Gorm = new Student("Gorm", 12, 3);

    classRoom1.StudentList.Add(oliver);
    classRoom1.StudentList.Add(kevin);

    Console.WriteLine(classRoom1.ClassName + "\n" + classRoom1.SemesterStart + "\n");
    classRoom1.StudentList.ForEach(student => Console.WriteLine(student));

    classRoom1.CountMonth();
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Fejl: {ex.Message}");
}