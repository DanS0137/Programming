using ListOfNotes.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ListOfNotes.View
{
    public partial class MainScreen : UserControl
    {
        List<Note> _noteList = new List<Note>();
        Note _currentNote;

        public MainScreen()
        {
            InitializeComponent();
            string path = Environment.ExpandEnvironmentVariables("%appdata%") + @"\Notes";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            var directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles();
            files = files.OrderByDescending(x => File.GetCreationTime(x.FullName)).ToArray();
            foreach (FileInfo file in files)
            {
                StreamReader sr = new StreamReader(file.FullName);
                string name = file.Name;
                DateTime date = DateTime.Parse(sr.ReadLine());
                NoteTheme theme = (NoteTheme)Enum.Parse(typeof(NoteTheme), sr.ReadLine());
                string text = sr.ReadToEnd();
                _currentNote = new Note(name, theme, text, date);
                _noteList.Add(_currentNote);
                NotesListBox.Items.Add(_currentNote.Name);
                sr.Close();
            }
        }

        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NotesListBox.SelectedIndex == -1) return;
            _currentNote = _noteList[NotesListBox.SelectedIndex];
            ThemeComboBox.SelectedItem = _currentNote.Theme.ToString();
            NameTextBox.Text = _currentNote.Name;
            TextTextBox.Text = _currentNote.Text;
            CreationTimeLabel.Text = "Время создания: " + _currentNote.CreationTime.ToString();
            CreationTimeLabel.Visible = true;
        }

        private void AddNewNoteButton_Click(object sender, EventArgs e)
        {
            _noteList.Insert(0, new Note());
            NotesListBox.Items.Insert(0, "Новая заметка");
            NotesListBox.SelectedIndex = 0;
        }

        private void SaveNoteButton_Click(object sender, EventArgs e)
        {
            if (NotesListBox.SelectedIndex == -1) return;
            foreach (Note note in _noteList)
            {
                if (note.Name == NameTextBox.Text)
                {
                    MessageForm messageForm = new MessageForm();
                    messageForm.MessageLabel.Text = "Заметка с этим названием уже существует. При продолжении старая заметка будет удалена. Желаете продолжить?";
                    if (!(messageForm.ShowDialog() == DialogResult.OK))
                    {
                        return;
                    }
                }
            }
            try
            {
                _currentNote.Name = NameTextBox.Text;
            }
            catch
            {
                MessageForm messageForm = new MessageForm();
                messageForm.MessageLabel.Text = "Название заметки введено некорректно (хотя бы 1 символ и не больше 100).";
                if (messageForm.ShowDialog() == DialogResult.OK) messageForm.Close();
                return;
            }
            _currentNote.Theme = (NoteTheme)Enum.Parse(typeof(NoteTheme), ThemeComboBox.SelectedItem.ToString());
            _currentNote.Text = TextTextBox.Text;
            int itemsLength = NotesListBox.Items.Count;
            for (int i = 0; i < itemsLength; i++)
            {
                if (i == NotesListBox.SelectedIndex) continue;
                if (NotesListBox.Items[i].ToString() == _currentNote.Name)
                {
                    NotesListBox.Items.RemoveAt(i);
                    break;
                }
            }
            foreach (Note note in _noteList)
            {
                if (note == _currentNote) continue;
                if (note.Name == NameTextBox.Text)
                {
                    _noteList.Remove(note);
                    break;
                }
            }
            _noteList.Remove(_currentNote);
            _noteList.Insert(0, new Note(NameTextBox.Text, (NoteTheme)Enum.Parse(typeof(NoteTheme),
                ThemeComboBox.SelectedItem.ToString()), TextTextBox.Text, DateTime.Now));
            _currentNote = _noteList[0];
            CreationTimeLabel.Text = "Время создания: " + _currentNote.CreationTime.ToString();
            NotesListBox.Items.RemoveAt(NotesListBox.SelectedIndex);
            NotesListBox.Items.Insert(0, _currentNote.Name);
            NotesListBox.SelectedIndex = 0;
            NameTextBox.BackColor = Color.White;
            ThemeComboBox.BackColor = Color.White;
            string path = Environment.ExpandEnvironmentVariables("%appdata%")
                + @"\Notes\" + $"{_currentNote.Name}";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (FileStream fs = File.Create(path))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(_currentNote.CreationTime.ToString() + "\n");
                fs.Write(info, 0, info.Length);
                info = new UTF8Encoding(true).GetBytes(_currentNote.Theme + "\n");
                fs.Write(info, 0, info.Length);
                info = new UTF8Encoding(true).GetBytes(_currentNote.Text);
                fs.Write(info, 0, info.Length);
            }
        }

        private void DeleteNoteButton_Click(object sender, EventArgs e)
        {
            if (NotesListBox.SelectedIndex == -1) return;
            MessageForm messageForm = new MessageForm();
            messageForm.MessageLabel.Text = "Вы уверены, что желаете удалить эту заметку?";
            if (!(messageForm.ShowDialog() == DialogResult.OK))
            {
                return;
            }
            _noteList.RemoveAt(NotesListBox.SelectedIndex);
            NotesListBox.Items.RemoveAt(NotesListBox.SelectedIndex);
            string path = Environment.ExpandEnvironmentVariables("%appdata%")
                + @"\Notes\" + $"{_currentNote.Name}";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            ThemeComboBox.SelectedIndex = -1;
            NameTextBox.Text = "";
            TextTextBox.Text = "";
            NameTextBox.BackColor = Color.White;
            ThemeComboBox.BackColor = Color.White;
            CreationTimeLabel.Visible = false;
        }
    }
}
