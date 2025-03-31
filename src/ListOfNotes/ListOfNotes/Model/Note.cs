using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfNotes.Model
{
    internal class Note
    {
        /// <summary>
        /// Название заметки.
        /// </summary>
        private string _name;
        /// <summary>
        /// Тема заметки.
        /// </summary>
        private NoteTheme _theme;
        /// <summary>
        /// Текст заметки.
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Время последнего изменения заметки.
        /// </summary>
        private readonly DateTime _creationTime;

        /// <summary>
        /// Возвращает или задаёт название заметки. Длина строки должна находиться в диапозоне от 1 до 100 символов включительно.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 101 && value.Length > 0) _name = value;
                else throw new ArgumentException();
            }
        }
        /// <summary>
        /// Возвращает или задаёт тему заметки. Является объектом перечисления <see cref="NoteTheme"/>.
        /// </summary>
        public NoteTheme Theme
        {
            get => _theme;
            set
            {
                if (value == NoteTheme.Финансы || value == NoteTheme.Дом ||
                    value == NoteTheme.Работа || value == NoteTheme.Спорт) _theme = value;
                else throw new ArgumentException();
            }
        }
        /// <summary>
        /// Возвращает время создания заметки.
        /// </summary>
        public DateTime CreationTime
        {
            get => _creationTime;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Note"/>.
        /// </summary>
        /// <param name="name">Название заметки. Длина строки должна находиться в диапозоне от 1 до 100 символов включительно.</param>
        /// <param name="theme">Тема заметки. Является объектом перечисления <see cref="NoteTheme"/>.</param>
        /// <param name="text">Текст заметки.</param>
        public Note(string name, NoteTheme theme, string text, DateTime date)
        {
            Name = name;
            Theme = theme;
            Text = text;
            _creationTime = date;
        }

        public Note()
        {
            _creationTime = DateTime.Now;
        }
    }
}
