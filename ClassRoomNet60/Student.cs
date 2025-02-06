using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
  public class Student
    {

        public string Name {  get; set; }
        public int Birthday { get; set; }
        public int BirthMonth {  get; set; }

        public Student(string name, int birthday, int birthmonth)
        {
            Name = name;
            Birthday = birthday;
            BirthMonth = birthmonth;
        }

        public override string ToString()
        {
            return Name + " Fødselsdags Dato " + Birthday + BirthMonth;
        }
    }
}
