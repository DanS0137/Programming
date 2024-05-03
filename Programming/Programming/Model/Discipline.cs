using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит информацию об экзамене по дисциплине.
    /// </summary>
    internal class Discipline
    {
        /// <summary>
        /// Возвращает и задаёт название дисциплины.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Количество часов занятий проведённых по дисциплине.
        /// </summary>
        private int _numberOfHours;
        /// <summary>
        /// Возвращает и задаёт имя преподавателя.
        /// </summary>
        public string ProfessorsName { get; set; }
        /// <summary>
        /// Оценка за экзамен.
        /// </summary>
        private int _examMark;
        /// <summary>
        /// Возвращает и задаёт дату проведения экзамена. Должна быть объектом класса <see cref="DateTime"/>
        /// </summary>
        public DateTime ExamDate { get; set; }

        /// <summary>
        /// Возвращает и задаёт количество часов занятий проведённых по дисциплине. Должно быть положительным числом.
        /// </summary>
        public int NumberOfHours
        {
            get => _numberOfHours;
            set
            {
                if (Validator.AssertOnPositiveValue(value, "Discipline.NumberOfHours")) _numberOfHours = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт оценку за экзамен. Должна быть цифрой от 2 до 5.
        /// </summary>
        public int ExamMark
        {
            get => _examMark;
            set
            {
                if (Validator.AssertValueInRange(value, 2, 5, "Discipline.ExamMark")) _examMark = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Discipline">.
        /// </summary>
        /// <param name="name">Название дисциплины.</param>
        /// <param name="numberOfHours">Количество часов занятий проведённых по дисциплине. Должно быть положительным числом.</param>
        /// <param name="professorsName">Имя преподавателя.</param>
        /// <param name="examMark">Оценка за экзамен. Должна быть цифрой от 2 до 5.</param>
        /// <param name="examDate">Дата экзамена. Должна быть объектом класса <see cref="DateTime"></param>
        public Discipline(string name, int numberOfHours, string professorsName, int examMark, DateTime examDate)
        {
            Name = name;
            NumberOfHours = numberOfHours;
            ProfessorsName = professorsName;
            ExamMark = examMark;
            ExamDate = examDate;
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Discipline">.
        /// </summary>
        public Discipline() { }
    }
}
