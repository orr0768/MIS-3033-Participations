using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    class Student
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthdate { get; set; }

        private int LuckyNumber { get; set; }

        public Student()
        {
            ID = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            Birthdate = DateTime.Now;
            LuckyNumber = 0;
        }

        public Student(int id, int luckyNumber)
        {
            ID = id;
            FirstName = string.Empty;
            LastName = string.Empty;
            Birthdate = DateTime.Now;
            LuckyNumber = luckyNumber;
        }
        public string BirthdateDayOfWeek()
        {
            return "";

        }

    }
}
