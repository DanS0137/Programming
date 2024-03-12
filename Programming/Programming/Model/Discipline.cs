using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Discipline
    {
        private string Name { get; set; }
        private int _numberOfHours;
        private string ProfessorsName { get; set; }
        private int _examMark;
        private DateTime ExamDate { get; set; }

        public int NumberOfHours
        {
            get => _numberOfHours;
            set
            {
                if (value < 0) throw new ArgumentException();
                _numberOfHours = value;
            }
        }
        public int ExamMark
        {
            get => _examMark;
            set
            {
                if (value < 2 || value > 5) throw new ArgumentException();
                _examMark = value;
            }
        }

        public Discipline(string name, int numberOfHours, string professorsName, int examMark, DateTime examDate)
        {
            Name = name;
            NumberOfHours = numberOfHours;
            ProfessorsName = professorsName;
            ExamMark = examMark;
            ExamDate = examDate;
        }

        public Discipline() { }
    }
}
