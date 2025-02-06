using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Student
    {

        public string Name { get; set; }
        public int Birthday { get; set; }
        private int _birthMonth { get; set; }

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




        public string Seasons(int BirthMonth)
        {
            string Result = "NoInfo";

            if (BirthMonth == 12 | BirthMonth == 1 | BirthMonth == 2)
            {
                return Result = "Winter";
            }
            if (BirthMonth == 3 || BirthMonth == 4 || BirthMonth == 5)
            {
               return Result = "Spring";
            }
            if (BirthMonth == 6 || BirthMonth == 7 || BirthMonth == 8)
            {
                return Result = "Summer";
            }
            if (BirthMonth == 9 || BirthMonth == 10 || BirthMonth == 11)
            {
               return Result = "Autumn";
            }
      
            
            return Result;
        }

        public int BirthMonth
        {
            get => _birthMonth;
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Birth month must be between 1 and 12.");
                }
                _birthMonth = value;
            }
        }

    }
}
