using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class ClassRoom
    {
        public string ClassName { get; set; }
        public List<Student> StudentList { get; set; } = new List<Student>();
        public DateTime SemesterStart { get; set; }

        public ClassRoom()
        {

        }

        public void CountMonth()
        {
            int winterCount = 0;
            int springCount = 0;
            int summerCount = 0;
            int autumnCount = 0;

            foreach (Student student in StudentList)
            {
                string season = student.Seasons(student.BirthMonth);

                switch (season)
                {
                    case "Winter":
                        winterCount++;
                        break;
                    case "Spring":
                        springCount++;
                        break;
                    case "Summer":
                        summerCount++;
                        break;
                    case "Autumn":
                        autumnCount++;
                        break;
                }
            }

            Console.WriteLine($"Winter birthdays: {winterCount}");
            Console.WriteLine($"Spring birthdays: {springCount}");
            Console.WriteLine($"Summer birthdays: {summerCount}");
            Console.WriteLine($"Autumn birthdays: {autumnCount}");
        }
    }
}
